namespace Holoon.Gladia.Models.Transcriptions;
public class DiarizationConfig
{
    public DiarizationConfig(int? numberOfSpeakers, int? minSpeakers, int? maxSpeakers)
    {
        NumberOfSpeakers = numberOfSpeakers;
        MinSpeakers = minSpeakers;
        MaxSpeakers = maxSpeakers;
    }
    public int? NumberOfSpeakers { get; set; }
    public int? MinSpeakers { get; set; }
    public int? MaxSpeakers { get; set; }
}