namespace Holoon.Gladia.Models.Transcriptions;
public class StructuredDataExtractionConfig
{
    public StructuredDataExtractionConfig(string[] classes)
    {
        Classes = classes;
    }
    public string[] Classes { get; set; }
}