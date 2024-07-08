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
        }

        public static int UpdateSeed()
        {
            Seed += DateTime.Now.Microsecond;
            return Seed;
        }
    }
}