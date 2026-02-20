namespace ConsoleApp1
{
    public interface IMovable
    {
        void Move(int distance);
        int TotalDistance { get; }
    }
    public class Robot : IMovable
    {
        public int TotalDistance { get; private set; }
    
        public void Move(int distance)
        {
            TotalDistance += distance;
            Console.WriteLine($"Robot moved {distance} units");
        }
    }

    public class Car : IMovable
    {
        public int TotalDistance { get; private set; }
        public string carName { get; private set; }
        public Car(string carName)
        {
            this.carName = carName;
        }
        public void Move(int distance)
        {
            TotalDistance += distance; 
            Console.WriteLine($"{carName} moved {distance} units");
        }
    }

    public class Drone : IMovable
    {
        public int TotalDistance { get; private set; }
    
        public void Move(int distance)
        {
            TotalDistance += distance;
            Console.WriteLine($"Drone moved {distance} units");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            void MoveAll(IMovable[] movable, int distance)
            {
                foreach (IMovable im in movable)
                {
                    im.Move(distance);
                }
            }

            IMovable[] fleet = { new Drone(), new Robot() };
            // MoveAll(fleet, 10);

            static int GetTotalDistanceTraveled(Car car, int[] movements)
            {
                // Console.WriteLine(car.Move(movements));
                int totalDistance = 0;
                foreach (var movement in movements)
                {
                    totalDistance += movement;
                }

                car.Move(totalDistance);
                return car.TotalDistance;
            }

            Console.WriteLine(GetTotalDistanceTraveled(new Car("Tesla"), [10, 20, 30]));
        }
    }
}