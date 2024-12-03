namespace Holoon.Gladia.Models.Transcriptions;
public class Metadata
{
    public Metadata(decimal audioDuration, int numberOfDistinctChannels, decimal billingTime, decimal transcriptionTime)
    {
        AudioDuration = audioDuration;
        NumberOfDistinctChannels = numberOfDistinctChannels;
        BillingTime = billingTime;
        TranscriptionTime = transcriptionTime;
    }
    public decimal AudioDuration { get; set; }
    public int NumberOfDistinctChannels { get; set; }
    public decimal BillingTime { get; set; }
    public decimal TranscriptionTime { get; set; }
}