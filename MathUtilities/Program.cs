namespace ConsoleApp1
{
    class MathUtilities
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MathUtilities.CalculateCircleArea(2.7));
            Console.WriteLine(MathUtilities.CalculateCircleArea(3.6));
            Console.WriteLine(MathUtilities.CalculateCircleArea(5.1));
        }
    }
}