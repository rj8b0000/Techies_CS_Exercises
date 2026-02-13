namespace ConsoleApp1
{
    class OptionalParameters
    {
        public static void Greet(string name, string prefix = "Hello")
        {
            Console.WriteLine($"{name}, {prefix}!");
        }
    }
}