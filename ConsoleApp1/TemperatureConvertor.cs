namespace ConsoleApp1
{
    class TemperatureConvertor
    {
        public static void Run()
        {
            double temp, tempInFarenhint;
            Console.WriteLine("** Temperature Converter **");
            
            temp = double.Parse(Console.ReadLine());
            tempInFarenhint = (temp * 1.8) + 32;
            
            Console.WriteLine("Temp in Farenhit: " + tempInFarenhint);
        }
    }
}