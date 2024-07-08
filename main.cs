using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter horizontal blocks:");
        string userInput = Console.ReadLine();
        Console.WriteLine("You entered: " + userInput);

        int number_of_horizontal_blocks = int.Parse(userInput);

        Console.WriteLine("Please enter vertical blocks:");
        userInput = Console.ReadLine();
        Console.WriteLine("You entered: " + userInput);

        int number_of_vertical_blocks = int.Parse(userInput);

        
        List<Block> blocks = new List<Block>();

    }

    public static List<Block> Blocks()
    {
        random = new Random();
    }
}




public class Block
{
    public int x;
    public int y;
    public int z;
    public string type;
    public City city;

    public Block(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}

public class City
{
    public string name;
    public Character mayor;
    public int population;
}

public class Culture
{
    public string name;
    public string language;
    public string religion;
    public List<string> dogmas;
}

public class Character
{
    public string name;
    public string race;
    public string goal;
    public List<string> traits;
    public List<string> skills;
}