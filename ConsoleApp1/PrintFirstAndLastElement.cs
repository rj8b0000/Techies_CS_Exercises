namespace ConsoleApp1
{
    class PrintFirstAndLastElement
    {
        public static void Run(params int[] numbers)
        {
            Console.WriteLine("First Element: " + numbers[0]);
            Console.WriteLine("Last Element: " + numbers[^1]);
        }
    }
}