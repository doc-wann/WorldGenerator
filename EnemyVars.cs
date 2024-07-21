public class Enemy
{
    public string Name = "Sample";

    public int Health = 100;

    public List<EnemyAction> Actions = new List<EnemyAction>();

    public int Defense = 5;

    public List<Dictionary<string, int>> LootTable = new List<Dictionary<string, int>>();

    public Enemy(string name, int health, List<EnemyAction> actions, int defense, List<Dictionary<string, int>> lootTable)
    {
        Name = name;
        Health = health;
        Actions = actions;
        Defense = defense;
        LootTable = lootTable;
    }
}

public class EnemyAction
{
    public string Name = "Sample";

    public int ToHit = 0;

    public int DiceNumber1 = 1;

    public int[] DiceType1 = Dices.D4;

    public int? DiceNumber2 = null!;

    public int[] DiceType2 = null!;

    public int BonusDamage = 0;

    public EnemyAction(string name, int diceNumber1, int[] diceType1, int? diceNumber2, int[] diceType2, int bonusDamage, int toHit)
    {
        Name = name;
        DiceNumber1 = diceNumber1;
        DiceType1 = diceType1;
        DiceNumber2 = diceNumber2;
        DiceType2 = diceType2;
        BonusDamage = bonusDamage;
        ToHit = toHit;
    }
}

class EnemyActions
{
    public static EnemyAction Bite = new EnemyAction("Bite", 1, Dices.D6, null, null, 0, 5);

    public static EnemyAction Claw = new EnemyAction("Claw", 2, Dices.D4, null, null, 0, 5);

    public static EnemyAction FireBreath = new EnemyAction("Fire Breath", 1, Dices.D6, 1, Dices.D6, 5, 5);

    public static EnemyAction IceBreath = new EnemyAction("Ice Breath", 1, Dices.D6, 1, Dices.D6, 5, 5);

    public static EnemyAction PoisonBreath = new EnemyAction("Poison Breath", 1, Dices.D6, 1, Dices.D6, 5, 5);
}
class Enemies
{
    public static Enemy Zombie = new Enemy("Zombie", 14, new List<EnemyAction> { EnemyActions.Bite, EnemyActions.Claw }, 5, new List<Dictionary<string, int>> { new Dictionary<string, int> { { "Gold", 10 },{"Potion: Health", 1}} });
}