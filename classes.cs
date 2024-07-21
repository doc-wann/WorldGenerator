
using WorldGenerator;

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
    public int strenght;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;
    public string?[] traits;
    public string classes;
    public int HP;
    public int MP;
    public int XP;
    public int level;

    public List<Action> actions = new List<Action>();

    public PlayerCharacter()
    {
        string? name = "Tav";
        string? surname = "of the Hill";
        string? race = "Human";
        string? goal = "To Conquer the World!";
        int strenght = 10;
        int dexterity = 10;
        int constitution = 10;
        int intelligence = 10;
        int wisdom = 10;
        int charisma = 10;
        string?[] traits = null!;
        string?[] skills = null!;
        int XP = 0;
        int level = 1;
        int HP = 0;
        int MP = 0;
        List<Action> actions = new List<Action>();
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
}

public class Action
{
    public string name;
    public string description;
    public int level;
    public int toHit;
    public List<Dictionary<int, int>> damage;
    public string type;
    public string duration;


    public Action(string name, string description, int level, int toHit, List<Dictionary<int, int>> damage, string type, string duration)
    {
        this.name = name;
        this.description = description;
        this.level = level;
        this.toHit = toHit;
        this.damage = damage;
        this.type = type;
        this.duration = duration;
    }
}

public class ActionResult()
{
    public int toHit = 0;
    public int damage = 0;
    public string type = "";
}

public class ActionLists
{
    public static List<Action>? ActionsListLvL0 = new List<Action>();

    public static void PopulateActions()
    {
        Actions actions = new Actions(Program.MC);
        ActionsListLvL0 = new List<Action> {actions.Soco, actions.Espadada, actions.ChicoteDeEspinhos};

    }
}

public class Actions (PlayerCharacter character)
{
    //Level 0 Actions

    public Action Soco = new("Soco", "Você soca o alvo!", 0, character.strenght + character.level, new List<Dictionary<int, int>>{ new Dictionary<int, int> { { 1, 4 } } }, "Esmagamento", "INST");

    public Action Espadada = new Action("Espadada", "Você usa sua espada para rasgar o oponente!", 0, character.strenght + character.level, new List<Dictionary<int, int>>{ new Dictionary<int, int> { {1,10}, {character.strenght, 2}}}, "Corte", "INST");

    public Action ChicoteDeEspinhos = new Action("Chicote de Espinhos", "Um chicote de vinhas sai das suas mãos e ataca violentamente seus alvos!", 0, character.dexterity + character.intelligence, new List<Dictionary<int,int>>{new Dictionary<int, int>{ {2,6}, {character.dexterity, character.wisdom + character.intelligence}}}, "Corte", "INST");
}