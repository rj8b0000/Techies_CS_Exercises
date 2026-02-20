namespace ConsoleApp1
{
    public interface IMovable
    {
        string Move();
    }

    public class Bike : IMovable
    {
        public string Move()
        {
            return "Move Test from Bike";
        }
    }

    public class Car : IMovable
    {
        public string Move()
        {
            return "Move Test from Car";
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            static string TestMovement(IMovable movable)
            {
                return movable.Move();
            }
            static void MoveAll(IMovable[] movables)
            {
                foreach (var movable in movables)
                {
                    Console.WriteLine(movable.Move());
                }
            }
            // MoveAll(new IMovable[] { new TestMovement(), new Car() });
            Console.WriteLine(TestMovement(new Bike()));
        }
    }
}