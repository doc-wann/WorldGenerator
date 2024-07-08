namespace CultureVars
{
    internal class BuilderCulture
    {
        public class CultureVars
        {
            public static List<string> nameMiddle = new List<string> { "Empire", "Kingdom", "Republic", "Federation", "Alliance", "Union", "Confederation", "Commonwealth"};
            public static List<string> nameStart = new List<string> { "Great", "Mighty", "Holy", "Free", "United", "Eternal", "Peaceful", "Enlightened"};
            public static List<string> nameEnd = new List<string> { "Of the North", "Of the South", "Of the East", "Of the West", "Of the Mountains", "Of the Sea", "Of the Forest", "Of the Plains"};
            public static List<string> languages = new List<string> { "Common", "Elvish", "Dwarvish", "Orcish", "Goblin", "Troll", "Ogre", "Halfling"};
            public static List<string> religions = new List<string> { "Monotheism", "Polytheism", "Atheism", "Pantheism", "Animism", "Totemism", "Shamanism", "Druidism"};
            public static List<string> dogmas = new List<string> { "Peace", "War", "Knowledge", "Ignorance", "Freedom"};
        }

        public static string GetName()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.UpdateSeed();
            
           
           string Name = $"{CultureVars.nameStart[rnd.Next(0, CultureVars.nameStart.Count)]} {CultureVars.nameMiddle[rnd.Next(0, CultureVars.nameMiddle.Count)]} {CultureVars.nameEnd[rnd.Next(0, CultureVars.nameEnd.Count)]}";

            return Name;
        }

        public static string GetLanguage()
        {
            
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.UpdateSeed();
            
            return CultureVars.languages[rnd.Next(0, CultureVars.languages.Count)];
        }

        public static string GetReligion()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.UpdateSeed();
            
            return CultureVars.religions[rnd.Next(0, CultureVars.religions.Count)];
        }

        public static string[] GetDogmas()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.UpdateSeed();
            
            string[] dogmas = new string[3];
            for (int i = 0; i < 3; i++)
            {
                dogmas[i] = CultureVars.dogmas[rnd.Next(0, CultureVars.dogmas.Count)];
            }
            return dogmas;
        }

        public static Culture BuildRandomCulture()
        {
            Culture culture  = new Culture();

            culture.name = GetName();
            culture.language = GetLanguage();
            culture.religion = GetReligion();
            culture.dogmas = GetDogmas();

            return culture;
        }

        public static Culture BuildCulture(string name, string language, string religion, string[] dogmas)
        {
            Culture culture = new Culture();

            culture.name = name;
            culture.language = language;
            culture.religion = religion;
            culture.dogmas = dogmas;

            return culture;
        }

        public static List<Culture> CulturesGenerator()
        {
            Random rnd = new Random(WorldGenerator.Program.Seed);

            WorldGenerator.Program.UpdateSeed();
            
            List<Culture> cultures = new List<Culture>();
            int CultureNumber = rnd.Next(2, 8);

            for (int i = 0; i < CultureNumber; i++)
            {
                cultures.Add(BuildRandomCulture());
            }

            return cultures;
        }
    }
}