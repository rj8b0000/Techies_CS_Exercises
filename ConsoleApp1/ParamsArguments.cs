namespace ConsoleApp1
{
    class ParamsArguments
    {
        public static void SumAll(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine($"Sum of all numbers is {sum}");
        }
    }
}