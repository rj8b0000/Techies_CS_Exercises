namespace ConsoleApp1
{
    class JaggedArray
    {
        public static void Run()
        {
            int[][] numbers = new int[][]
            {
                new int[] { 1 },
                new int[] { 1, 2 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3, 4 }
            };
            for (int row = 0; row < numbers.Length; row++)
            {
                for (int col = 0; col < numbers[row].Length; col++)
                {
                    Console.Write(numbers[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}