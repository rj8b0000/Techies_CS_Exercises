namespace ConsoleApp1
{

    public class AreaOfCircle
    {
        public static void Run()
        {
            double radi, areaOfCircle;
            Console.WriteLine("Enter the Radius of the circle: ");
            radi = Convert.ToDouble(Console.ReadLine());
            areaOfCircle = Math.PI * radi * radi;
            Console.WriteLine("The area of circle is: " + areaOfCircle);
        }
    }
}