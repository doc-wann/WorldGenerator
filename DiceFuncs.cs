using WorldGenerator;

class Dices
{
    public static int Roll(int[] dice)
    {
        return new Random(Program.Seed).Next(dice[0], dice[1]);
    }

    public static int[] D4 = { 1, 4 };

    public static int[] D6 = { 1, 6 };

    public static int[] D8 = { 1, 8 };

    public static int[] D10 = { 1, 10 };

    public static int[] D12 = { 1, 12 };

    public static int[] D20 = { 1, 20 };

    public static int[] D100 = { 1, 100 };
}