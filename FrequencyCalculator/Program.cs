using System;

class FrequencyCalculator{
    static void count_freq(String str)
    {
        SortedDictionary<String, int> mp = new SortedDictionary<String, int>();
        String []arr = str.Split(' ');
        for(int i = 0; i < arr.Length; i++)
        {
            if (mp.ContainsKey(arr[i]))
            {
                mp[arr[i]] = mp[arr[i]] + 1;
            }
            else
            {
                mp.Add(arr[i], 1);
            }
        }
        foreach(KeyValuePair<String, int> entry in mp)
        {
            Console.WriteLine(entry.Key + " - " + entry.Value);
        }
    }
    public static void Main(String[] args)
    {
        String str;
        Console.WriteLine("** Welcome to FrequencyCalculator **");
        Console.Write("Enter the string: ");
        str = Console.ReadLine();
        count_freq(str);
    }
}