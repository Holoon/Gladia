namespace Holoon.Gladia.Models.Transcriptions;
public class Utterance
{
    public Utterance(string language, decimal start, decimal end, decimal confidence, int channel, int? speaker, Words[] words, string text)
    {
        Language = language;
        Start = start;
        End = end;
        Confidence = confidence;
        Channel = channel;
        Speaker = speaker;
        Words = words;
        Text = text;
    }
    public string Language { get; set; }
    public decimal Start { get; set; }
    public decimal End { get; set; }
    public decimal Confidence { get; set; }
    public int Channel { get; set; }
    public int? Speaker { get; set; }
    public Words[] Words { get; set; }
    public string Text { get; set; }
}