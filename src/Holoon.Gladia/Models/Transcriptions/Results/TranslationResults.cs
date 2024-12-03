namespace Holoon.Gladia.Models.Transcriptions.Results;
public class TranslationResults : BaseResult
{
    public TranslationResults(bool success, bool isEmpty, decimal execTime, Error? error, Transcription[]? results) : base(success, isEmpty, execTime, error)
    {
        Results = results;
    }
    public Transcription[]? Results { get; set; }
}
