namespace DictionaryWebApp.Models
{
    public class Definition
    {
        public string? definition { get; set; } = string.Empty;
        public string[]? synonyms { get; set; } = null;
        public string[]? antonyms { get; set; } = null;
        public string? example { get; set; } = string.Empty;
    }
}
