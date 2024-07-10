namespace AuxFuncs
{
    internal class Auxiliary
    {
        public static void PrintCharacter(Character Char)
        {

            Console.WriteLine($"Name: {Char.name} {Char.surname}");
            Console.WriteLine($"Race: {Char.race}");
            Console.WriteLine($"Goal: {Char.goal}");
            Console.WriteLine("Traits:");
            foreach (string? trait in Char.traits!)
            {
                Console.WriteLine($"- {trait}");
            }
            Console.WriteLine("Skills:");
            foreach (string? skill in Char.skills!)
            {
                Console.WriteLine($"- {skill}");
            }
        }

        public static void ClearConsoleAsk()
        {
            Console.WriteLine("\n=============\nPress any key to continue...\n=============");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }


        public static void AnimatedText(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);
            }
        }

        public static void PrintCharacterSelf(PlayerCharacter character)
        {
            int width = 50; // Width of the character sheet
            string border = new string('=', width);
            string separator = new string('-', width);

            // Print header
            Console.WriteLine(border);
            Console.WriteLine(CenterText("Character Sheet", width));
            Console.WriteLine(border);

            // Print character basic info
            Console.WriteLine(CenterText($"Name: {character.name} {character.surname}", width));
            Console.WriteLine(CenterText($"Class: {character.classes}", width));
            Console.WriteLine(CenterText($"Race: {character.race}", width));
            Console.WriteLine(CenterText($"Level: {character.level}", width));
            Console.WriteLine(CenterText($"XP: {character.XP}", width));

            Console.WriteLine(separator);

            Console.WriteLine(CenterText($"HP: {character.HP} | MP: {character.MP}", width));


            // Print attributes
            Console.WriteLine(CenterText("Attributes", width));
            Console.WriteLine(separator);
            Console.WriteLine(CenterText($"Strength: {character.strenght}", width));
            Console.WriteLine(CenterText($"Dexterity: {character.dexterity}", width));
            Console.WriteLine(CenterText($"Constitution: {character.constitution}", width));
            Console.WriteLine(CenterText($"Intelligence: {character.intelligence}", width));
            Console.WriteLine(CenterText($"Wisdom: {character.wisdom}", width));
            Console.WriteLine(CenterText($"Charisma: {character.charisma}", width));
            Console.WriteLine(separator);

            // Print traits
            Console.WriteLine(CenterText("Traits", width));
            Console.WriteLine(separator);
            if (character.traits != null && character.traits.Length > 0)
            {
                foreach (string trait in character.traits)
                {
                    Console.WriteLine(CenterText($"- {trait}", width));
                }
            }
            else
            {
                Console.WriteLine(CenterText("- None", width));
            }
            Console.WriteLine(separator);
            Console.WriteLine(border);
        }

        public static void PrintCulture(Culture Culture)
        {
            Console.WriteLine($"Name: {Culture.name}");
            Console.WriteLine($"Language: {Culture.language}");
            Console.WriteLine($"Religion: {Culture.religion}");
            Console.WriteLine("Dogmas:");
            foreach (string? dogma in Culture.dogmas)
            {
                Console.WriteLine($"- {dogma}");
            }
        }

        public static void PrintCity(City City)
        {
            Console.WriteLine($"Name: {City.name}");
            Console.WriteLine("Mayor:");
            PrintCharacter(City.mayor!);
            Console.WriteLine($"Population: {City.population}");
            Console.WriteLine("Culture:");
            PrintCulture(City.culture!);
        }

        public static string CenterText(string text, int width)
        {
            if (text.Length >= width)
                return text;

            int leftPadding = (width - text.Length) / 2;
            int rightPadding = width - text.Length - leftPadding;

            return new string(' ', leftPadding) + text + new string(' ', rightPadding);
        }

        
    }
}