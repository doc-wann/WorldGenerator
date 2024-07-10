using System.Security.Cryptography.X509Certificates;
using CityVars;

namespace BlockBuilder
{
    internal class BlockBuilder
    {
        public class BlockVars
        {
            public static List<string> blockTypes = new List<string> { "Grassland", "Forest", "Desert", "Mountain", "Sea", "Tundra", "Sea", "Sea" };
        }
        public static Block BuildBlock(int x, int y, int z)
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);
            WorldGenerator.Program.UpdateSeed();

            Block block = new Block();

            block.x = x;
            block.y = y;
            block.z = z;
            block.type = BlockVars.blockTypes[rnd.Next(0, BlockVars.blockTypes.Count)];

            if (rnd.Next(0, 200) == 42)
            {
                block.city = BuilderCity.BuildRandomCity(WorldGenerator.Program.cultures);
            }

            return block;
        }

        public static List<Block> BlocksGenerator(int x, int y, int z)
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);
            List<Block> blocks = new List<Block>();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    blocks.Add(BuildBlock(i, j, z));
                }
            }
            return blocks;
        }

        public static List<Block> BuildMap(int x, int y, int z)
        {
            List<Block> blocks = BlocksGenerator(x, y, z);

            //FixNote: This world building strat is a bit naive, but it's a good start. Improve it later.
            foreach (Block block in blocks)
            {
                //Console.WriteLine($"Block at {block.x}, {block.y}, {block.z} is a {block.type} block.");
                if (block.y == 0)
                {
                    Console.Write("\n");
                }
                Console.Write(BlockToPiece(block.type!));
                Console.ResetColor();
            }

            Console.BackgroundColor = ConsoleColor.Black;

            return blocks;
        }

        public static char BlockToPiece(string type)
        {
            switch (type)
            {
                case "Grassland":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return '█';
                }
                case "Forest":
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    return '█';
                }
                case "Desert":
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    return '█';
                }
                case "Mountain":
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return '█';
                }
                case "Sea":
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    return '█';
                }
                case "Tundra":
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return '█';
                }
                default:
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    return '█';
                }
            }
        }
    }
}