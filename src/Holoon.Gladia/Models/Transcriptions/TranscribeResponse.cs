namespace Holoon.Gladia.Models.Transcriptions;
public class TranscribeResponse
{
    public TranscribeResponse(string id, string requestId, int version, string status, DateTime createdAt, DateTime? completedAt, object? customMetadata, int? errorCode, string kind, File? file, TranscribeRequest? requestParams, TranscribeResult? result)
    {
        Id = id;
        RequestId = requestId;
        Version = version;
        Status = status;
        CreatedAt = createdAt;
        CompletedAt = completedAt;
        CustomMetadata = customMetadata;
        ErrorCode = errorCode;
        Kind = kind;
        File = file;
        RequestParams = requestParams;
        Result = result;
    }
    public string Id { get; set; }
    public string RequestId { get; set; }
    public int Version { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public object? CustomMetadata { get; set; }
    public int? ErrorCode { get; set; }
    public string Kind { get; set; }
    public File? File { get; set; }
    public TranscribeRequest? RequestParams { get; set; }
    public TranscribeResult? Result { get; set; }
}