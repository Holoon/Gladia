namespace Holoon.Gladia.Models.Transcriptions;
public class TranscribeRequest
{
    public TranscribeRequest(string audioUrl,
        string? contextPrompt = null,
        string[]? customVocabulary = null,
        bool? detectLanguage= null,
        bool? enableCodeSwitching = null, 
        CodeSwitchingConfig? codeSwitchingConfig = null, 
        string? language = null, 
        bool? subtitles = null,
        SubtitlesConfig? subtitlesConfig = null, 
        bool? diarization = null, 
        DiarizationConfig? diarizationConfig = null, 
        bool? translation = null,
        TranslationConfig? translationConfig = null, 
        bool? summarization = null, 
        SummarizationConfig? summarizationConfig = null,
        bool? moderation = null, 
        bool? namedEntityRecognition = null, 
        bool? chapterization = null, 
        bool? nameConsistency = null,
        bool? customSpelling = null, 
        CustomSpellingConfig? customSpellingConfig = null, 
        bool? structuredDataExtraction = null,
        StructuredDataExtractionConfig? structuredDataExtractionConfig = null,
        bool? sentimentAnalysis = null, 
        bool? audioToLlm = null,
        AudioToLlmConfig? audioToLlmConfig = null, 
        bool? sentences = null, 
        bool? displayMode = null, 
        bool? diarizationEnhanced = null)
    {
        AudioUrl = audioUrl;
        ContextPrompt = contextPrompt;
        CustomVocabulary = customVocabulary;
        DetectLanguage = detectLanguage;
        EnableCodeSwitching = enableCodeSwitching;
        CodeSwitchingConfig = codeSwitchingConfig;
        Language = language;
        Subtitles = subtitles;
        SubtitlesConfig = subtitlesConfig;
        Diarization = diarization;
        DiarizationConfig = diarizationConfig;
        Translation = translation;
        TranslationConfig = translationConfig;
        Summarization = summarization;
        SummarizationConfig = summarizationConfig;
        Moderation = moderation;
        NamedEntityRecognition = namedEntityRecognition;
        Chapterization = chapterization;
        NameConsistency = nameConsistency;
        CustomSpelling = customSpelling;
        CustomSpellingConfig = customSpellingConfig;
        StructuredDataExtraction = structuredDataExtraction;
        StructuredDataExtractionConfig = structuredDataExtractionConfig;
        SentimentAnalysis = sentimentAnalysis;
        AudioToLlm = audioToLlm;
        AudioToLlmConfig = audioToLlmConfig;
        Sentences = sentences;
        DisplayMode = displayMode;
        DiarizationEnhanced = diarizationEnhanced;
    }

    public string AudioUrl { get; set; }
    public string? ContextPrompt { get; set; }
    public string[]? CustomVocabulary { get; set; }
    public bool? DetectLanguage { get; set; }
    public bool? EnableCodeSwitching { get; set; }
    public CodeSwitchingConfig? CodeSwitchingConfig { get; set; }
    public string? Language { get; set; }
    public bool? Subtitles { get; set; }
    public SubtitlesConfig? SubtitlesConfig { get; set; }
    public bool? Diarization { get; set; }
    public DiarizationConfig? DiarizationConfig { get; set; }
    public bool? Translation { get; set; }
    public TranslationConfig? TranslationConfig { get; set; }
    public bool? Summarization { get; set; }
    public SummarizationConfig? SummarizationConfig { get; set; }
    public bool? Moderation { get; set; }
    public bool? NamedEntityRecognition { get; set; }
    public bool? Chapterization { get; set; }
    public bool? NameConsistency { get; set; }
    public bool? CustomSpelling { get; set; }
    public CustomSpellingConfig? CustomSpellingConfig { get; set; }
    public bool? StructuredDataExtraction { get; set; }
    public StructuredDataExtractionConfig? StructuredDataExtractionConfig { get; set; }
    public bool? SentimentAnalysis { get; set; }
    public bool? AudioToLlm { get; set; }
    public AudioToLlmConfig? AudioToLlmConfig { get; set; }
    public bool? Sentences { get; set; }
    public bool? DisplayMode { get; set; }
    public bool? DiarizationEnhanced { get; set; }
}