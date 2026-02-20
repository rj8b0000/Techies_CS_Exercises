namespace ConsoleApp1
{
    public interface IVehicle
    {
        string Brand { get; }
        public string GetDescription()
        {
            return $"Vehicle: {Brand}";
        }
    }

    class Bike : IVehicle
    {
        public string Brand { get; }

        public Bike(string brand)
        {
            Brand = brand;
        }
    }

    class Car : IVehicle
    {
        public string Brand { get; set; }
        public int HorsePower { get; set; }

        public Car(string brand, int horsePower)
        {
            Brand = brand;
            HorsePower = horsePower;
        }

        public string GetDescription()
        {
            return $"Car: {Brand} {HorsePower} CC";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            static string GetVehicleInfo(IVehicle vehicle)
            {
                return vehicle.GetDescription();
            }

            Console.WriteLine(GetVehicleInfo(new Bike("David Putra")));
            Console.WriteLine(
            GetVehicleInfo(new Car("Bugatti", 7000)));
        }
    }
}
