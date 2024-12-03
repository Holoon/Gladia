namespace Holoon.Gladia.Models.Transcriptions.Results;
public class NamedEntityRecognition : BaseResult
{
    public NamedEntityRecognition(bool success, bool isEmpty, decimal execTime, Error? error, string? entity) : base(success, isEmpty, execTime, error)
    {
        Entity = entity;
    }
    public string? Entity { get; set; }
}