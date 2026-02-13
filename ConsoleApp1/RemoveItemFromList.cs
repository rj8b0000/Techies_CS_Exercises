namespace ConsoleApp1
{
    class RemoveItemFromList
    {
        public static void Run(List<string> items, string itemsToRemove)
        {
            items.Remove(itemsToRemove);
            foreach (var item in items) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Final List after removing items");
        }
    }
}