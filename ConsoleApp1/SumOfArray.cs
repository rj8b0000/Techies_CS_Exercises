namespace ConsoleApp1
{
    class SumOfArray
    {
        public static void Run()
        {
            int[] num = { 23, 45, 67, 34 };
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine("The sum of array is: " + sum);
        }
    }
}