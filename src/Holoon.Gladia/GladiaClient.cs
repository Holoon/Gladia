using System.Net.Http.Json;
using System.Text.Json;
using Holoon.Gladia.Models.Transcriptions;
using Holoon.Gladia.Models.Uploads;
using Microsoft.Extensions.Logging;

namespace Holoon.Gladia;
public class GladiaClient : IDisposable
{
    public string BaseAddress { get; set; } = "https://api.gladia.io";
    public string? ApiKey { get; set; }
    private readonly ILogger? _Logger;
    private HttpClient? _Client;
    public HttpClient Client 
    {
        get
        {
            if (_Client != null) 
                return _Client;
            
            if (ApiKey == null)
                throw new InvalidOperationException($"{nameof(ApiKey)} must be set before.");
        
            _Client = new HttpClient
            {
                BaseAddress = new Uri(BaseAddress)
            };
            _Client.DefaultRequestHeaders.Add("x-gladia-key", ApiKey);
            return _Client;
        }
    }
    private readonly JsonSerializerOptions _DefaultOptions = new()
    {
        PropertyNamingPolicy = new SnakeCasePolicy()
    };
    public GladiaClient(ILogger? logger)
    {
        _Logger = logger;
    }

    public async Task<UploadResponse?> UploadAsync(byte[] file, string fileName, string contentType, CancellationToken cancellationToken)
    {
        var formData = new MultipartFormDataContent();
        var content = new ByteArrayContent(file);
        formData.Add(content, "audio", fileName);
        content.Headers.Add("Content-Type", contentType);

        var response = await Client.PostAsync("v2/upload", formData, cancellationToken);
        return await GetResponseAsync<UploadResponse>(response, cancellationToken);
    }
    public async Task<TranscribeResponse?> TranscribeAsync(TranscribeRequest transcribeRequest, CancellationToken cancellationToken)
    {
        var jsonRequest = JsonContent.Create(transcribeRequest, options: _DefaultOptions);
        
        var response = await Client.PostAsync("v2/pre-recorded", jsonRequest, cancellationToken);
        var instantResponse = await GetResponseAsync<TranscribeInstantResponse>(response, cancellationToken);

        if (instantResponse?.ResultUrl == null)
        {
            _Logger?.LogError("Gladia AI return url is null.");
            return null;
        }

        TranscribeResponse? asyncResponse;
        do
        {
            const int K_DELAY = 1 * 1000;
            await Task.Delay(K_DELAY, cancellationToken);
            
            var poolingResponse = await Client.GetAsync(instantResponse.ResultUrl, cancellationToken);
            asyncResponse = await GetResponseAsync<TranscribeResponse>(poolingResponse, cancellationToken);
            
        } while (asyncResponse?.Status is not ("done" or "error"));

        return asyncResponse;
    }
    
    private async Task<TResponse?> GetResponseAsync<TResponse>(HttpResponseMessage response, CancellationToken cancellationToken)
    {
        if (!response.IsSuccessStatusCode)
        {
            var statusCode = response.StatusCode;
            var reasonPhrase = response.ReasonPhrase;
            _Logger?.LogError("Gladia AI: Response error. (StatusCode: {statusCode}. reason: {reasonPhrase})", statusCode, reasonPhrase);
            return default;
        }
        
        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        try
        {
            var jSon = JsonSerializer.Deserialize<TResponse>(content, _DefaultOptions);
            return jSon;
        }
        catch (JsonException ex)
        {
            _Logger?.LogError(ex, "Gladia AI: Deserialize error. (content: {content})", content);
            throw;
        }
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);  
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
            _Client?.Dispose();
    }
}
