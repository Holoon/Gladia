namespace Holoon.Gladia.Models.Transcriptions;
public class Error
{
    public Error(int statusCode, string exception, string message)
    {
        StatusCode = statusCode;
        Exception = exception;
        Message = message;
    }
    public int StatusCode { get; set; }
    public string Exception { get; set; }
    public string Message { get; set; }
}