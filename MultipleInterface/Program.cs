namespace ConsoleApp1
{
    public interface IMovable
    {
        string Move();
    };

    public interface ISoundMaker
    {
        string MakeSound();
    }

    class Robot : IMovable, ISoundMaker
    {
        public string Move()
        {
            return "Moving forward";
        }

        public string MakeSound()
        {
            return "Beep boop";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            static string TestRobot(Robot robot)
            {
                return robot.Move() + " " + robot.MakeSound();
            }

            Console.WriteLine(TestRobot(new Robot()));
        }
    }
    
}