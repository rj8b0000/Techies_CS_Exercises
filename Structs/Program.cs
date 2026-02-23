namespace ConsoleApp1
{

    class Program
    {
        public struct Point
        {
            public int X;
            public int Y;
        }

        public static string DescribePoint(int x, int y)
        {
            Point p1 =  new Point { X = x, Y = y };
            return $"Point({p1.X},{p1.Y})";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DescribePoint(-5, 10));
            Console.WriteLine(DescribePoint(15, 25));
            Console.WriteLine(DescribePoint(12, 24));
        }
    }
}