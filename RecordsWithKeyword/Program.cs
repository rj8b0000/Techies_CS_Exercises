namespace ConsoleApp1
{
    public record Person(string Name, int Age);

    public record Product(string Name, double Price, int Stock);

    public record Employee(string Name, string Title, double Salary);

    class Program
    {
        public static Person UpdateAge(Person person, int newAge)
        {
            var person1 = person;
            var updatedPerson = person1 with { Age = newAge};
            return updatedPerson;
        }

        public static Product ApplyDiscount(Product product, double updatedPrice)
        {
            var product1 = product;
            var updatePrice = product1 with {  Price = updatedPrice };
            return updatePrice;
        }

        public static Employee Promote(Employee employee, string title, double salary)
        {
            var employee1 = employee;
            var updatedEmployee = employee1 with { Title = title, Salary = salary };
            return updatedEmployee;
        }
        public static void Main(string[] args)
        {
            Person p1 = new Person("John Doe", 20);
            Console.WriteLine(p1);
            Console.WriteLine("Updated Person" + UpdateAge(p1, 25));
            Product prod1 = new Product("Laptop", 99000, 10);
            Console.WriteLine(prod1);
            Console.WriteLine("Updated Product" + ApplyDiscount(prod1, 89000));
            Employee emp1 = new Employee("Rudraksh Jani", "Software Developer Trainee", 10000);
            Console.WriteLine(emp1);
            Console.WriteLine("Update Employee Detail" + Promote(emp1, "Junior Software Engineer", 25000));
        }
    }
}