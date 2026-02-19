namespace ConsoleApp1
{
    class Player
    {
        private static int instanceCount;

        public Player(params string[] names)
        {
            instanceCount = names.Length;
        }
        
        public static int CreatePlayers(int count)
        {
            instanceCount = count;
            return instanceCount;
        }

        public static int GetInstanceCount()
        {
            return instanceCount;
        }

        public static void ResetCount()
        {
            instanceCount = 0;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var player = new Player(["Rudraksh", "Alice", "Bob"]);
            Console.WriteLine("Players get: "+Player.GetInstanceCount());
            Console.WriteLine("Players created: " + Player.CreatePlayers(0));
            Console.WriteLine("Players created: " + Player.CreatePlayers(5));
            Console.WriteLine("Players get: "+Player.GetInstanceCount());
            
        }
    }
}