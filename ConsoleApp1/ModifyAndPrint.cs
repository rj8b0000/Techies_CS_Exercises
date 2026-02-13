namespace ConsoleApp1
{
    class ModifyAndPrint
    {
        public static void Run(int[] numbers)
        {
            numbers[1] = 99;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}