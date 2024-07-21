public class AsciiArtsFuncs
{
    static string ChoiceMenuAlpha = @"
    ===================================
    |                                 |
    | 1. Generate a random character  |
    | 2. Generate a random world      |
    | 3. Generate a random city       |
    | 4. Generate player character    |
    | 5. Exit                         |
    | 6. Play music                   |
    | 7. Stop music                   |
    | 8. Combat                       |
    |                                 |
    ===================================";
    public static int ChoiceMenu()
    {
        Console.WriteLine(ChoiceMenuAlpha);
        int choice;
        do
        {
            Console.Write("Enter your choice: ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8);

        return choice;
    }

    static string ChoiceMenuCombat = @"
    ===================================
    |          Combat Options         |
    | 1. Attack                       |
    | 2. Defend                       |
    | 3. Check Sheet                  |
    | 4. Run                          |
    ===================================";

    static string MonsterSample = @"
        .-.
       (o.o)
        |=|
       __|__
     //.=|=.\\
    // .=|=. \\
    \\ .=|=. //
    ";

    static string PlayerSample = @"
            /-\       
        ===========   
           |'='|   \\/
          __|-|__   \/
         //|-  |\\  ||
        // | - | \\ ||
        \\ |  -|  \\||
     ";


    public static void SideBySidePrint(string Player, string Monster)
    {
        string[] monsterLines = MonsterSample.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        string[] playerLines = PlayerSample.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        // Determine the maximum number of lines between the two samples
        int maxLength = Math.Max(monsterLines.Length, playerLines.Length);

        // Print each line side by side with proper alignment
        for (int i = 0; i < maxLength; i++)
        {
            string monsterLine = i < monsterLines.Length ? monsterLines[i] : new string(' ', monsterLines[0].Length);
            string playerLine = i < playerLines.Length ? playerLines[i] : string.Empty;

            Console.WriteLine($"{playerLine.PadRight(20)}    {monsterLine}");
        }
    }

    public static int CombatMenu(Enemy enemy)
    {
        SideBySidePrint(PlayerSample, MonsterSample);
        Console.WriteLine($"\nYou are facing a {enemy.Name}!\n");
        Console.WriteLine($"{enemy.Name} Health: {enemy.Health}\n");
        Console.WriteLine(ChoiceMenuCombat);
        int choice;
        do
        {
            Console.Write("Enter your choice: ");
        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4);

        return choice;
    }
}