namespace ConsoleApp1
{
    public record Person(string Name, int Age);
    class Program
    {
        public static Person CreatePerson(string name, int age)
        {
            Person person = new Person(name, age);
            return person;
        }

        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}";
        }

        public static bool ArePeopleEqual(Person person1, Person person2)
        {
            if (person1.Age == person2.Age && person1.Name == person2.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            var person = CreatePerson("John Doe", 20);
            Console.WriteLine("Person created" + person);
            var person2 = CreatePerson("Rudraksh Jani", 20);
            Console.WriteLine("Person created" + person2);
            var person3 = CreatePerson("John Doe", 20);
            Console.WriteLine(GetPersonInfo(person));
            Console.WriteLine(ArePeopleEqual(person, person3));
            
        }
    }
}