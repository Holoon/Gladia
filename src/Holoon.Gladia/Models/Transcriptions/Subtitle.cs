namespace Holoon.Gladia.Models.Transcriptions;
public class Subtitle
{
    public Subtitle(string format, string subtitles)
    {
        Format = format;
        Subtitles = subtitles;
    }
    public string Format { get; set; }
    public string Subtitles { get; set; }
}