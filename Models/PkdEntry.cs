namespace PokDex.Models
{
    public class PokemonSpecies
    {
        public List<FlavorTextEntry> flavor_text_entries { get; set; } = new List<FlavorTextEntry>();
    }

    public class FlavorTextEntry
    {
        public string? flavor_text { get; set; } 
        public Language? language { get; set; }
        public Version? version { get; set; }
    }

    public class Language
    {
        public string? name { get; set; } = "";
    }

    public class Version
    {
        public string? name { get; set; } = "";
    }

}
