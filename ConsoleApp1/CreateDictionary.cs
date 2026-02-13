namespace ConsoleApp1
{
    class  CreateDictionary
    {
        public static Dictionary<string, int> CreateAgeDictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Alice", 1);
            ages.Add("Bob", 2);
            ages.Add("Charlie", 3);
            return ages;
        }
    }
}