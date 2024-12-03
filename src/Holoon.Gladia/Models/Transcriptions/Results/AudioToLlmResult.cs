namespace Holoon.Gladia.Models.Transcriptions.Results;
public class AudioToLlm : BaseResult
{
    public AudioToLlm(bool success, bool isEmpty, decimal execTime, Error? error, AudioToLlmResult[]? results) : base(success, isEmpty, execTime, error)
    {
        Results = results;
    }
    public AudioToLlmResult[]? Results { get; set; }
}
public class AudioToLlmResult : BaseResult
{
    public AudioToLlmResult(bool success, bool isEmpty, decimal execTime, Error? error, PromptResponse? results) : base(success, isEmpty, execTime, error)
    {
        Results = results;
    }
    public PromptResponse? Results { get; set; }
}
public class PromptResponse
{
    public PromptResponse(string? prompt, string? response)
    {
        Prompt = prompt;
        Response = response;
    }
    public string? Prompt { get; set; }
    public string? Response { get; set; }
}