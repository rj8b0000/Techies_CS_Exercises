namespace ConsoleApp1
{
    public class Person
    {
        public int Age;
        public string Name;
        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }
    }
}

