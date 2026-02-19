namespace AutoProperties
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Email = "test@gmail.com";
        }
    }


    class Program
    {
        public static void GetPersonInfo(string name, int age)
        {
            Person p1 = new Person(name, age);
            Console.WriteLine($"{p1.Name}, {p1.Age}, {p1.Email}");
        }
        public static void Main(string[] args)
        {
            GetPersonInfo("John Doe", 23);
            GetPersonInfo("Rudraksh Jani", 19);
            GetPersonInfo("Shen GraceWell", 36);
            
        }
    }
}