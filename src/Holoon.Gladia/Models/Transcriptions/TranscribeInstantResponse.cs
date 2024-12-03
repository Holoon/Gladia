namespace Holoon.Gladia.Models.Transcriptions;
public class TranscribeInstantResponse
{
    public TranscribeInstantResponse(string id, string resultUrl)
    {
        Id = id;
        ResultUrl = resultUrl;
    }
    public string Id { get; set; }
    public string ResultUrl { get; set; }
}