namespace ConsoleApp1
{
    public class AddAndCalc
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Calc(int a, int b, int c)
        {
            return Add(a, b) * c;
        }
    }
}