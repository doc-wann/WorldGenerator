using System.Security.Cryptography;
using System.Xml.Serialization;

namespace CharacterVars
{
    internal class BuilderChar
    {
        public class CharacterVars
        {
            public static List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Heidi" };
            public static List<string> surnames = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };
            public static List<string> race = new List<string> { "Human", "Elf", "Dwarf", "Orc", "Goblin", "Troll", "Ogre", "Halfling" };
            public static List<string> goals = new List<string> { "To become the best", "To find the truth", "To get rich", "To get revenge", "To find love", "To get power", "To get famous", "To get respect" };
            public static List<string> traits = new List<string> { "Brave", "Cowardly", "Honest", "Loyal", "Greedy", "Proud", "Vain", "Cunning" };
            public static List<string> skills = new List<string> { "Swordfighting", "Archery", "Magic", "Alchemy", "Sneaking", "Persuasion", "Crafting", "Haggling" };
        }

        public static string GetName()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; 
            return CharacterVars.names[rnd.Next(0, CharacterVars.names.Count)];
        }
        public static string GetSurname()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; 
            return CharacterVars.surnames[rnd.Next(0, CharacterVars.surnames.Count)];
        }
        public static string GetRace()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; 
            return CharacterVars.race[rnd.Next(0, CharacterVars.race.Count)];
        }
        public static string GetGoal()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; 
            return CharacterVars.goals[rnd.Next(0, CharacterVars.goals.Count)];
        }
        public static string[] GetTraits()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; string[] traits = new string[3];
            for (int i = 0; i < 3; i++)
            {
                traits[i] = CharacterVars.traits[rnd.Next(0, CharacterVars.traits.Count)];
            }
            return traits;
        }
        public static string[] GetSkills()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.Seed += 1; string[] skills = new string[3];
            for (int i = 0; i < 3; i++)
            {
                skills[i] = CharacterVars.skills[rnd.Next(0, CharacterVars.skills.Count)];
            }
            return skills;
        }

        public static Character BuildRandomCharacter()
        {
            Character character = new Character();
            character.name = GetName();
            character.surname = GetSurname();
            character.race = GetRace();
            character.goal = GetGoal();
            character.traits = GetTraits();
            character.skills = GetSkills();

            return character;
        }
    }
}