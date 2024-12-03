namespace Holoon.Gladia.Models.Transcriptions.Results;
public class ObjectResponse : BaseResult
{
    public ObjectResponse(bool success, bool isEmpty, decimal execTime, Error? error, object? results) : base(success, isEmpty, execTime, error)
    {
        Results = results;
    }
    public object? Results { get; set; }
}