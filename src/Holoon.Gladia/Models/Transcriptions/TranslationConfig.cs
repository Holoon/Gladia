namespace Holoon.Gladia.Models.Transcriptions;
public class TranslationConfig
{
    public TranslationConfig(string[] targetLanguages, string? model, bool? matchOriginalUtterances)
    {
        TargetLanguages = targetLanguages;
        Model = model;
        MatchOriginalUtterances = matchOriginalUtterances;
    }
    public string[] TargetLanguages { get; set; }
    public string? Model { get; set; }
    public bool? MatchOriginalUtterances { get; set; }
}