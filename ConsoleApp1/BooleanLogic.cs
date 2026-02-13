namespace ConsoleApp1
{
    class BooleanLogic
    {
        public static void Run()
        {
            bool inp1, inp2;
            Console.WriteLine("Enter Input 1");
            inp1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Input 2");
            inp2 = Convert.ToBoolean(Console.ReadLine());
            if (inp1 && inp2)
                Console.WriteLine("Both are same");
            else if (inp1 || inp2)
                Console.WriteLine("One of them is true");
            else if(inp1 != inp2)
                Console.WriteLine("Input one not equal to input two");
        }
    }
}