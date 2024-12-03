namespace Holoon.Gladia.Models.Transcriptions;
public class SubtitlesConfig
{
    public SubtitlesConfig(string[]? formats, decimal? minimumDuration, double? maximumDuration, int? maximumCharactersPerRow, int? maximumRowsPerCaption, string? style)
    {
        Formats = formats;
        MinimumDuration = minimumDuration;
        MaximumDuration = maximumDuration;
        MaximumCharactersPerRow = maximumCharactersPerRow;
        MaximumRowsPerCaption = maximumRowsPerCaption;
        Style = style;
    }
    public string[]? Formats { get; set; }
    public decimal? MinimumDuration { get; set; }
    public double? MaximumDuration { get; set; }
    public int? MaximumCharactersPerRow { get; set; }
    public int? MaximumRowsPerCaption { get; set; }
    public string? Style { get; set; }
}