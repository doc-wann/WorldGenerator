using System;
using CharacterVars;
using CultureVars;
using CityVars;
using BlockBuilder;
using AuxFuncs;

namespace WorldGenerator
{
    internal class Program
    {
        public static int Seed = DateTime.Now.Microsecond;
        public static List<Culture> cultures = BuilderCulture.CulturesGenerator();
        static void Main(string[] args)
        {
            BlockBuilder.BlockBuilder.BuildMap(10, 100, 1);

            Character character = BuilderChar.BuildRandomCharacter();

            Auxiliary.PrintCharacterSelf(character);

            ClearConsole();
        }

        public static int UpdateSeed()
        {
            Seed += DateTime.Now.Microsecond;
            return Seed;
        }

        public static void ClearConsole()
        {
            Console.WriteLine("\n=============\nPress any key to continue...\n\n=============");
            Console.ReadKey();
            Console.Clear();
        }
    }
}