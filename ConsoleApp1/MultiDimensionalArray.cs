namespace ConsoleApp1
{
    class MultiDimensionalArray
    {
        public static void PrintGrid()
        {
            int[,] data =
            {
                {1, 2, 3},
                {5, 6, 7},
                {9, 10, 11},
            };
            for (int row = 0; row < data.GetLength(0); row++)
            {
                for (int col = 0; col < data.GetLength(1); col++)
                {
                    Console.WriteLine(data[row, col]);
                }
            }
            
        }
    }
}