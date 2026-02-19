namespace ConsoleApp1
{
    class StaticCounter
    {
        static int counter = 0;
        
        public static void GetNxtCounter()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static void GetCurrentCounter()
        {
            Console.WriteLine(counter);
        }
        public static void resetCounter()
        {
            counter = 0;
            Console.WriteLine(counter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticCounter.GetNxtCounter();
            StaticCounter.GetNxtCounter();
            StaticCounter.GetCurrentCounter();
            StaticCounter.resetCounter();
            StaticCounter.GetNxtCounter();
        }
    }
}

