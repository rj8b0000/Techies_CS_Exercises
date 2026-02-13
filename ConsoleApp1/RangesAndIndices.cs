namespace ConsoleApp1
{
    class RangesAndIndices
    {
        public static void GetLastTwoElements(int[] numbers)
        {
            int[] lastTwoElements = numbers[^2..];
            Console.WriteLine(string.Join(" ",lastTwoElements));
        }
    }
}