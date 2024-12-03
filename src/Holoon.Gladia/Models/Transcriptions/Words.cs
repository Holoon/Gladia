namespace Holoon.Gladia.Models.Transcriptions;
public class Words
{
    public Words(string word, decimal start, decimal end, decimal confidence)
    {
        Word = word;
        Start = start;
        End = end;
        Confidence = confidence;
    }
    public string Word { get; set; }
    public decimal Start { get; set; }
    public decimal End { get; set; }
    public decimal Confidence { get; set; }
}