namespace PokDex.Util
{

    public static class PokeUtil
    {
        public const string Pokeball = "Poke-ball.png";
        public const string Superball = "Super-ball.png";
        public const string Ultraball = "Ultra-ball.png";
        public const string Masterball = "Master-ball.png";
       
     

    public static string GetRandomBall()
     {
            var pokeballArray = new string[] {Pokeball, Superball, Ultraball, Masterball };
            var random = new Random();
            string randomball = pokeballArray[random.Next(pokeballArray.Length)];
            return randomball;
     }

        public static double GetPokemonHeightInMeters(int height)
        {
            return Convert.ToDouble(height) / 10;
        }
        public static double GetPokemonWeightInKilograms(int weight)
        {
            return Convert.ToDouble(weight) / 10;
        }
    }
}