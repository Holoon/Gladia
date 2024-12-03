namespace Holoon.Gladia.Models.Uploads;
public class AudioMetadata
{
    public AudioMetadata(string id, string filename, string extension, int size, double audioDuration, int numberOfChannels)
    {
        Id = id;
        Filename = filename;
        Extension = extension;
        Size = size;
        AudioDuration = audioDuration;
        NumberOfChannels = numberOfChannels;
    }
    public string Id { get; set; }
    public string Filename { get; set; }
    public string Extension { get; set; }
    public int Size { get; set; }
    public double AudioDuration { get; set; }
    public int NumberOfChannels { get; set; }
}