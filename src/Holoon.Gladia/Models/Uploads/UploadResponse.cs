namespace Holoon.Gladia.Models.Uploads;
public class UploadResponse
{
    public UploadResponse(string audioUrl, AudioMetadata? audioMetadata)
    {
        AudioUrl = audioUrl;
        AudioMetadata = audioMetadata;
    }
    public string AudioUrl { get; set; }
    public AudioMetadata? AudioMetadata { get; set; }
}