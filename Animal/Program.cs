namespace ConsoleApp1
{
    public class Animal
    {
        public string Name {get; set; }
        public int Age {get; set;}
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void AnimalMethod()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }
    }

    public class Dog : Animal
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public void MakeDogSpeak()
        {
            Console.WriteLine($"Woof! My name is {Name}");
        }

        public void GetDogInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Coco", 1);
            dog.MakeDogSpeak();
            dog.GetDogInfo();
            dog.AnimalMethod();
        }
    }
}