using System.Collections.Generic;

namespace PokDex.Util
{
    public static class PokeStatName
    {
        // Creamos un diccionario con los nombres para los stats
        private static readonly Dictionary<string, string> StatNameMap = new Dictionary<string, string>
        {
            { "hp", "HP" },
            { "attack", "ATK" },
            { "defense", "DEF" },
            { "special-attack", "S.ATK" },
            { "special-defense", "S.DEF" },
            { "speed", "SPD" }
        };

        // metodo para que haga uso del diccionario y devuelva el nombre corto
        public static string GetShortName(string orgName)
        {
            return StatNameMap.TryGetValue(orgName, out var shortName) ? shortName : orgName;
        }
    }
}