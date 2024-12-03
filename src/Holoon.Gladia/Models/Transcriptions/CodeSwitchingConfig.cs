namespace Holoon.Gladia.Models.Transcriptions;
public class CodeSwitchingConfig
{
    public CodeSwitchingConfig(string[]? languages)
    {
        Languages = languages;
    }
    public string[]? Languages { get; set; }
}