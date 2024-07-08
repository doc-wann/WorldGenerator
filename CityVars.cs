using System;
using CharacterVars;
using CultureVars;


namespace CityVars
{
    internal class BuilderCity
    {
        class CityVars
        {
            public static List<string> cityNames = new List<string> { "Kingsport", "Queensport", "Dukesport", "Princesport", "Baronsport", "Earlsport", "Lordsport", "Ladysport" };
            public static List<string> cityTypes = new List<string> { "Port", "Castle", "Town", "City", "Village", "Hamlet", "Fortress", "Stronghold" };
        }

        public static string GetName()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1;
            return $"{CityVars.cityNames[rnd.Next(0, CityVars.cityNames.Count)]} {CityVars.cityTypes[rnd.Next(0, CityVars.cityTypes.Count)]}";
        }

        public static Character GetMayor()
        {
            return BuilderChar.BuildRandomCharacter();
        }

        public static Culture GetCulture(List<Culture> COTW)
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1;
            return COTW[rnd.Next(0, COTW.Count)];
        }

        public static int GetPopulation()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; return rnd.Next(1000, 100000);
        }

        public static City BuildRandomCity(List<Culture> culture)
        {
            City city = new City();
            city.name = GetName();
            city.mayor = GetMayor();
            city.culture = GetCulture(culture);
            city.population = GetPopulation();
            
            return city;
        }
    }
}