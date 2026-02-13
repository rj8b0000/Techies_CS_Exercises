namespace ConsoleApp1
{
    class DictionaryStockCheck
    {
        public static void GetValueSafely(Dictionary<string, int> inventory, string item)
        {
            if (inventory.ContainsKey(item))
            {
                Console.WriteLine($"{item} items of {inventory[item]} quantity is already in stock");
            }
            else
            {
                Console.WriteLine($"{item} stock now found");
            }
        }
    }
}