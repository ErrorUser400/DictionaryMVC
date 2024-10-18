namespace DictionaryWebApp.Models
{
    public class Meaning
    {
        public string? partOfSpeech { get; set; } = string.Empty;
        public List<Definition>? definitions { get; set; } = null;
        public string[]? synonyms { get; set; } = null;
        public string[]? antonyms { get; set; } = null;
    }
}
