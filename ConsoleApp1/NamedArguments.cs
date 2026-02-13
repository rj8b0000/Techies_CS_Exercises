using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class NamedArguments
    {
        public static void createProfile(string name, int age, string city, bool isActive)
        {
            Console.WriteLine($"{name}, {age}, {city}, {isActive}");
        }
        public static void Run(int scenario)
        {
            switch (scenario)
            {
                case 1:
                    createProfile(isActive: true, city: "London", age: 34, name: "John");
                    break;
                case 2:
                    createProfile(city: "Ahmedabad", age: 34, name: "John",  isActive: true);
                    break;
                case 3:
                    createProfile(age: 34, name: "Maxwell", isActive: true, city: "Texas");
                    break;
                case 4:
                    createProfile("Rudraksh", 20, "Ahmedabad", false);
                    break;
                default:
                    Console.WriteLine("Invalid Case Entered");
                    break;
            }

        }
    }
}