namespace Holoon.Gladia.Models.Transcriptions;
public class SummarizationConfig
{
    public SummarizationConfig(string type)
    {
        Type = type;
    }
    public string Type { get; set; }
}