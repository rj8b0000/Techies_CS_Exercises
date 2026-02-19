namespace ReadOnlyProperties
{
    public class Person
    {
        public string Name { get; }
        public int Year { get; }
        public Person(string name, int year)
        {
            Name = name;
            Year = year;
        }
    }

    class Program
    {
        public static void GetPersonInfo(string name, int year)
        {
            Person person = new Person(name, year);
            Console.WriteLine($"{person.Name} was born in {person.Year}");
        }
        static void Main(string[] z)
        {
            GetPersonInfo("Rudraksh", 2006);
            GetPersonInfo("Lorem Ipsum", 2001);
        }
    }
}