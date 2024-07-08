static public class Block
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

static public class City
{
    public string name;
    public Character mayor;
    public int population;
}

static public class Culture
{
    public string name;
    public string language;
    public string religion;
    public string[3] dogmas;
}

static public class Character
{
    public string name;
    public string race;
    public string goal;
    public string[3] traits;
    public string[3] skills;
}