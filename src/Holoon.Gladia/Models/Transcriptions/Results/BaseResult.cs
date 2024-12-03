namespace Holoon.Gladia.Models.Transcriptions.Results;
public abstract class BaseResult
{
    protected BaseResult(bool success, bool isEmpty, decimal execTime, Error? error)
    {
        Success = success;
        IsEmpty = isEmpty;
        ExecTime = execTime;
        Error = error;
    }
    public bool Success { get; set; }
    public bool IsEmpty { get; set; }
    public decimal ExecTime { get; set; }
    public Error? Error { get; set; }
}