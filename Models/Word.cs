namespace DictionaryWebApp.Models
{
    public class Word
    {
        public string? word { get; set; } = string.Empty;
        public List<Phonetic>? phonetics { get; set; } = null;
        public List<Meaning>? meanings { get; set; } = null;
        public License? license { get; set; } = null;
        public string[]? sourceUrls { get; set; } = null;
    }
}
