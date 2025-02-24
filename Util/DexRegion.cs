using System.Collections.Generic;
using System.Linq;

namespace PokDex.Util
{
    public class DexRegion
    {
        public class Region
        {
            public string Name { get; set; } = "";
            public int StartId { get; set; }
            public int EndId { get; set; }
        }

        public static readonly Dictionary<string, Region> Regiones = new Dictionary<string, Region>
        {
            {"all", new Region{Name = "all",StartId=1,EndId=1025 } },
            {"Kanto", new Region {Name="Kanto",StartId=1,EndId=151 } },
            {"Johto", new Region {Name="Johto",StartId=152,EndId=251} },
            {"Hoenn", new Region {Name="Hoenn",StartId=252,EndId=386} },
            {"Sinnoh", new Region {Name="Sinnoh",StartId=387,EndId=493} },
            {"Unova", new Region {Name="Unova",StartId=494,EndId=649} },
            {"Kalos", new Region {Name="Kalos",StartId=650,EndId=721} },
            {"Alola", new Region {Name="Alola",StartId=722,EndId=809} },
            {"Galar", new Region {Name="Galar",StartId=810,EndId=905} },
            {"Paldea", new Region {Name="Paldea",StartId=906,EndId=1025} }
        };

        public static List<int> FilterRegion(string regionName, List<int> allPokemonId)
        {
            if (Regiones.TryGetValue(regionName, out Region? region))
            {
                return allPokemonId.Where(id => id >= region.StartId && id <= region.EndId).ToList();
            }

            return new List<int>();
        }
    }
}
