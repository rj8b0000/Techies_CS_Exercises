namespace ConsoleApp1;

class Program
{
    public struct Player
    {
        public int initialHealth;
    }

    public static int GetOriginalHealthAfterModifyingCopy(int initialHealth, int damageToApply)
    {
        Player player = new Player{initialHealth = initialHealth};
        Player p2 =  new Player();
        p2.initialHealth = damageToApply;
        return player.initialHealth;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine(GetOriginalHealthAfterModifyingCopy(100, 30));
        Console.WriteLine(GetOriginalHealthAfterModifyingCopy(50, 50));
    }
}