using Holoon.Gladia.Models.Transcriptions.Results;

namespace Holoon.Gladia.Models.Transcriptions;
public class TranscribeResult
{
    public TranscribeResult(Metadata metadata, Transcription? transcription, TranslationResults? translation, StringResult? summarization, StringResult? moderation, NamedEntityRecognition? namedEntityRecognition, StringResult? nameConsistency, StringResult? customSpelling, StringResult? structuredDataExtraction, StringResult? sentimentAnalysis, AudioToLlm? audioToLlm, StringArrayResult? displayMode, ObjectResponse? chapters)
    {
        Metadata = metadata;
        Transcription = transcription;
        Translation = translation;
        Summarization = summarization;
        Moderation = moderation;
        NamedEntityRecognition = namedEntityRecognition;
        NameConsistency = nameConsistency;
        CustomSpelling = customSpelling;
        StructuredDataExtraction = structuredDataExtraction;
        SentimentAnalysis = sentimentAnalysis;
        AudioToLlm = audioToLlm;
        DisplayMode = displayMode;
        Chapters = chapters;
    }
    public Metadata Metadata { get; set; }
    public Transcription? Transcription { get; set; }
    public TranslationResults? Translation { get; set; }
    public StringResult? Summarization { get; set; }
    public StringResult? Moderation { get; set; }
    public NamedEntityRecognition? NamedEntityRecognition { get; set; }
    public StringResult? NameConsistency { get; set; }
    public StringResult? CustomSpelling { get; set; }
    public StringResult? StructuredDataExtraction { get; set; }
    public StringResult? SentimentAnalysis { get; set; }
    public AudioToLlm? AudioToLlm { get; set; }
    public StringArrayResult? DisplayMode { get; set; }
    public ObjectResponse? Chapters { get; set; }
}