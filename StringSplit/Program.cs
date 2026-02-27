namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string words = "Hello World";
            string csv = "apple,banana,orange,cherry";
            string[] array = words.Split(' ');
            string[] fruitsArray = csv.Split(',');
            Console.WriteLine(array[0]);
            Console.WriteLine(fruitsArray[0]);
        }
    }
}