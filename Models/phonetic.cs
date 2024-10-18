namespace DictionaryWebApp.Models
{
    public class Phonetic
    {
        public string? text { get; set; } = string.Empty;
        public string? audio { get; set; } = string.Empty;
        public string? sourceUrl { get; set; } = string.Empty;
        public License? license { get; set; } = null;
    }
}
