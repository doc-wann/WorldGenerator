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
    }
}