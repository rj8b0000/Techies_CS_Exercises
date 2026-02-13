namespace ConsoleApp1
{
    class StringManipulation
    {
        public static void Run()
        {
            string str1;
            Console.Write("Enter the string");
            str1 = Console.ReadLine();
            Console.WriteLine("The Length of string is " + str1.Length + "and its first character is " + str1[0]);
        }
    }
}