namespace Holoon.Gladia.Models.Transcriptions;
public class CustomSpellingConfig
{
    public CustomSpellingConfig(object spellingDictionary)
    {
        SpellingDictionary = spellingDictionary;
    }
    public object SpellingDictionary { get; set; }
}