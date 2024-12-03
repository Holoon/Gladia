using Holoon.Gladia.Models.Transcriptions.Results;

namespace Holoon.Gladia.Models.Transcriptions;
public class Transcription
{
    public Transcription(string fullTranscript, string[] languages, StringArrayResult[]? sentences, Subtitle[]? subtitles, Utterance[] utterances)
    {
        FullTranscript = fullTranscript;
        Languages = languages;
        Sentences = sentences;
        Subtitles = subtitles;
        Utterances = utterances;
    }
    public string FullTranscript { get; set; }
    public string[] Languages { get; set; }
    public StringArrayResult[]? Sentences { get; set; }
    public Subtitle[]? Subtitles { get; set; }
    public Utterance[] Utterances { get; set; }
}