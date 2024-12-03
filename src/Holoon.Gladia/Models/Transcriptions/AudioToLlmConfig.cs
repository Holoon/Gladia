namespace Holoon.Gladia.Models.Transcriptions;
public class AudioToLlmConfig
{
    public AudioToLlmConfig(string[] prompts)
    {
        Prompts = prompts;
    }
    public string[] Prompts { get; set; }
}