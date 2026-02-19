namespace  ConsoleApp1
{
    class Thiskeyword
    {
        private string name;
        private int age;
        public Thiskeyword(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void CreateAndDescribePerson()
        {
            Console.WriteLine($"{this.name} is a {this.age} years old person.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thiskeyword person = new Thiskeyword("Bob", 50);
            person.CreateAndDescribePerson();
        }
    }
}