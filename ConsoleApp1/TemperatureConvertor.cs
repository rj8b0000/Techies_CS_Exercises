using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class TemperatureConvertor
    {
        public static void CheckTemp()
        {
            double temp, tempInFarenheit;
            Console.WriteLine("Enter the temperature in Celcius: ");
            temp = Convert.ToDouble(Console.ReadLine());
            tempInFarenheit = temp * 1.8 + 32;
            Console.WriteLine("The converted temperature is : " + tempInFarenheit);
        }

        public static void Run()
        {
            Retry:
            try
            {
                CheckTemp();
                Console.WriteLine("Would you want to covert temp again: [Y/N]");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Y":
                        goto Retry;
                    case "N":
                        break;
                    default:
                        Console.WriteLine("Please enter Y or N only");
                    goto Retry;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid string: " + e.Message);
                goto Retry;
            }

        }

    }
}