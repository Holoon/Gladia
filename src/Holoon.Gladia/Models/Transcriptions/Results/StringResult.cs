namespace Holoon.Gladia.Models.Transcriptions.Results;
public class StringResult : BaseResult
{
    public StringResult(bool success, bool isEmpty, decimal execTime, Error? error, string results) : base(success, isEmpty, execTime, error)
    {
        Results = results;
    }
    public string Results { get; set; }
}