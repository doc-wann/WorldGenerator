using System;

namespace PlayerManager
{
    public class CharacterCreator
    {
        private static readonly List<string> Races = new List<string> { "Human", "Elf", "Dwarf", "Halfling" };
        private static readonly List<string> Skills = new List<string> { "Acrobatics", "Arcana", "Athletics", "History", "Stealth" };

        public static PlayerCharacter CreateCharacter()
        {
            PlayerCharacter character = new PlayerCharacter();

            Console.Clear();
            PrintHeader("Character Creation");
            
            Console.Write("Enter character name: ");
            character.name = Console.ReadLine();

            Console.Write("Enter character surname: ");
            character.surname = Console.ReadLine();

            character.race = ChooseFromList("race", Races);

            int totalPoints = 8;
            Console.WriteLine($"\nDistribute {totalPoints} points among the following attributes (minimum 0 point in each):");
            character.strenght = DistributePoints("strength", ref totalPoints);
            character.dexterity = DistributePoints("dexterity", ref totalPoints);
            character.constitution = DistributePoints("constitution", ref totalPoints);
            character.intelligence = DistributePoints("intelligence", ref totalPoints);
            character.wisdom = DistributePoints("wisdom", ref totalPoints);
            character.charisma = DistributePoints("charisma", ref totalPoints);

            character.traits = ChooseTraitsOrSkills("traits", Skills);
            character.skills = ChooseTraitsOrSkills("skills", Skills);

            PrintFooter("Character Created Successfully!");
            character = PopulateCharacterStats(character);
            return character;
        }

        private static PlayerCharacter PopulateCharacterStats(PlayerCharacter character)
        {
            // FixNote: Weird Behaviour
            character.HP = (character.constitution * character.level) + 4;
            character.MP = (character.intelligence * character.level) + 4;
            character.XP = 0;
            character.level = 1;
            return character;
        }

        private static string ChooseFromList(string itemName, List<string> options)
        {
            Console.WriteLine($"\nChoose a {itemName}:");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            int choice;
            do
            {
                Console.Write($"Enter the number of the {itemName}: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > options.Count);

            return options[choice - 1];
        }

        private static int DistributePoints(string attributeName, ref int remainingPoints)
        {
            int value;
            do
            {
                Console.Write($"Enter {attributeName} (1-20, remaining points: {remainingPoints}): ");
            } while (!int.TryParse(Console.ReadLine(), out value) || value < 0 || value > 20 || value > remainingPoints);

            remainingPoints -= value;
            return value;
        }

        private static string[] ChooseTraitsOrSkills(string itemName, List<string> options)
        {
            Console.WriteLine($"\nChoose {itemName} (comma separated, available options: {string.Join(", ", options)}): ");
            string input = Console.ReadLine();
            string[] chosenItems = input?.Split(',') ?? new string[0];

            for (int i = 0; i < chosenItems.Length; i++)
            {
                chosenItems[i] = chosenItems[i].Trim();
                if (!options.Contains(chosenItems[i]))
                {
                    Console.WriteLine($"Invalid {itemName} choice: {chosenItems[i]}. Please try again.");
                    return ChooseTraitsOrSkills(itemName, options);
                }
            }

            return chosenItems;
        }

        private static void PrintHeader(string title)
        {
            int width = 50;
            string border = new string('=', width);
            Console.WriteLine(border);
            Console.WriteLine(CenterText(title, width));
            Console.WriteLine(border);
        }

        private static void PrintFooter(string message)
        {
            int width = 50;
            string border = new string('=', width);
            Console.WriteLine(border);
            Console.WriteLine(CenterText(message, width));
            Console.WriteLine(border);
        }

        private static string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text;

            int leftPadding = (width - text.Length) / 2;
            int rightPadding = width - text.Length - leftPadding;

            return new string(' ', leftPadding) + text + new string(' ', rightPadding);
        }
    }
}