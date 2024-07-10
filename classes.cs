
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

public class PlayerCharacter
{
    public string? name;
    public string? surname;
    public string? race;
    public string? strenght;
    public string? dexterity;
    public string? constitution;
    public string? intelligence;
    public string? wisdom;
    public string? charisma;
    public string?[]? traits;
    public string?[]? skills;

    public PlayerCharacter()
    {
        string? name = "Tav";
        string? surname = "of the Hill";
        string? race = "Human";
        string? goal = "To Conquer the World!";
        int? strenght = 10;
        int? dexterity = 10;
        int? constitution = 10;
        int? intelligence = 10;
        int? wisdom = 10;
        int? charisma = 10;
        string?[] traits = null!;
        string?[] skills = null!;
    }
}

public class Druid
{
    Dictionary<bool, int> UnlockedAttributes = new Dictionary<bool, int>()
    {
        {false, 0},
        {false, 1},
        {false, 2},
        {false, 3},
        {false, 4},
        {false, 5},
        {false, 6},
        {false, 7},
        {false, 8},
        {false, 9},
        {false, 10},
        {false, 11},
        {false, 12},
    };

    class Spell
    {
        public string name;
        public string description;
        public int level;
        public string toHit;
        public string damage;
        public string range;
        public string type;
        public string duration;

        public Spell(string name, string description, int level, string toHit, string damage, string range, string type, string duration)
        {
            this.name = name;
            this.description = description;
            this.level = level;
            this.toHit = toHit;
            this.damage = damage;
            this.range = range;
            this.type = type;
            this.duration = duration;
        }
    }

}
