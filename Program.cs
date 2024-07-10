using System;
using CharacterVars;
using CultureVars;
using CityVars;
using BlockBuilder;
using AuxFuncs;
using PlayerManager;

namespace WorldGenerator
{
    internal class Program
    {
        public static int Seed = DateTime.Now.Microsecond;
        public static List<Culture> cultures = BuilderCulture.CulturesGenerator();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the World Generator!");

            ClearConsole();

            PlayerCharacter MC = PlayerManager.CharacterCreator.CreateCharacter();

            ClearConsole();

            Console.WriteLine("Character created:");
            AuxFuncs.Auxiliary.PrintCharacterSelf(MC);

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