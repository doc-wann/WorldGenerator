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

        public static void PrintCharacterSelf(Character character)
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
            Console.WriteLine(CenterText($"Race: {character.race}", width));
            Console.WriteLine(CenterText($"Goal: {character.goal}", width));
            Console.WriteLine(separator);

            // Print traits
            Console.WriteLine(CenterText("Traits", width));
            Console.WriteLine(separator);
            foreach (string trait in character.traits)
            {
                Console.WriteLine(CenterText($"- {trait}", width));
            }
            Console.WriteLine(separator);

            // Print skills
            Console.WriteLine(CenterText("Skills", width));
            Console.WriteLine(separator);
            foreach (string skill in character.skills)
            {
                Console.WriteLine(CenterText($"- {skill}", width));
            }
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