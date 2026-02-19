namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public virtual string GetInfo()
        {
            return $"Name of Person is {Name}";
        }
    }

    public class Employee : Person
    {
        public string Department { get; set; }

        public Employee(string name, string department) : base(name)
        {
            Department = department;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} - Works in {Department} Department";
        }
    }

    public class Program
    {
        public static void Main()
        {
            Employee e1 = new Employee("John Doe", "Sales");
            Console.WriteLine(e1.GetInfo());
        }
    }
}