namespace Holoon.Gladia.Models.Transcriptions.Results;
public class StringArrayResult : BaseResult
{
    public StringArrayResult(bool success, bool isEmpty, decimal execTime, Error? error, string[] results) : base(success, isEmpty, execTime, error)
    {
        Results = results;
    }
    public string[] Results { get; set; }
}