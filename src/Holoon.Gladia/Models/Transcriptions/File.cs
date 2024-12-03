namespace Holoon.Gladia.Models.Transcriptions;
public class File
{
    public File(string id, string? filename, string? source, decimal? audioDuration, int? numberOfChannels)
    {
        Id = id;
        Filename = filename;
        Source = source;
        AudioDuration = audioDuration;
        NumberOfChannels = numberOfChannels;
    }
    public string Id { get; set; }
    public string? Filename { get; set; }
    public string? Source { get; set; }
    public decimal? AudioDuration { get; set; }
    public int? NumberOfChannels { get; set; }
}