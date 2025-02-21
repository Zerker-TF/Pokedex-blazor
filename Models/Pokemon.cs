
using PokDex.Models;

namespace Pokedex.Models
{
    public class Pokemon

    {

        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public int height { get; set; } = 0;
        public int weight { get; set; } = 0;
        public Sprites sprites { get; set; } = new Sprites();
        public List<Stat> stats { get; set; } = new List<Stat>();
        public List<PokDex.Models.Type> types { get; set; } = new List<PokDex.Models.Type>();
        public List<FlavorTextEntry> flavor_text_entries { get; set; } = new List<FlavorTextEntry>();

    }
}