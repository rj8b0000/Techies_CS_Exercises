namespace ConsoleApp1
{
    class OutParameter
    {
        public static bool Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            if (divisor == 0)
            {
                quotient = 0;
                remainder = 0;
                
                return false;
            }
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine($"q = {quotient} & r = {remainder}");
            return true;
        }
    }
}