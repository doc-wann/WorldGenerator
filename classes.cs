
public class Block
{
    public int x;
    public int y;
    public int z;
    public string? type;
    public City? city;

    public Block()
    {
        int x = 0;
        int y = 0;
        int z = 0;
        string? type = "Undefined";
        City? city = null!;
    }
}

public class City
{
    public string? name;
    public Character? mayor;
    public Culture? culture;
    public int population;

    public City()
    {
        string? name = "Undefined";
        Character? mayor = null!;
        int? population = 0;
        Culture? culture = null!;
    }
}

public class Culture
{
    public string? name;
    public string? language;
    public string? religion;
    public string?[]? dogmas;

    public Culture()
    {
        string? name = "Undefined";
        string? language = "Undefined";
        string? religion = "Undefined";
        string?[] dogmas = null!;
    }
}

public class Character
{
    public string? name;
    public string? surname;
    public string? race;
    public string? goal;
    public string?[]? traits;
    public string?[]? skills;

    public Character()
    {
        string? name = "Undefined";
        string? surname = "Undefined";
        string? race = "Undefined";
        string? goal = "Undefined";
        string?[] traits = null!;
        string?[] skills = null!;
    }
}