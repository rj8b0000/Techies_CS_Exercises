namespace ConsoleApp1
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        public static string GetDayType(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return "Weekend";
                    break;
                case DayOfWeek.Monday:
                    return "WeekDay";
                    break;
                case DayOfWeek.Tuesday:
                    return "WeekDay";
                    break;
                case DayOfWeek.Wednesday:
                    return "WeekDay";
                    break;
                case DayOfWeek.Thursday:
                    return "WeekDay";
                    break;
                case DayOfWeek.Friday:
                    return "WeekDay";
                    break;
                case DayOfWeek.Saturday:
                    return "WeekEnd";
                    break;
                default:
                    return "Unknown";
                    break;
            }
        }

        public static int GetEnumValue(DayOfWeek day)
        {
            int value = (int)day;
            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetDayType(DayOfWeek.Monday));
            Console.WriteLine(GetDayType(DayOfWeek.Saturday));
            Console.WriteLine(GetDayType(DayOfWeek.Sunday));
            Console.WriteLine(GetDayType(DayOfWeek.Friday));
            Console.WriteLine(GetEnumValue(DayOfWeek.Sunday));
            Console.WriteLine(GetEnumValue(DayOfWeek.Monday));
            Console.WriteLine(GetEnumValue(DayOfWeek.Wednesday));
            Console.WriteLine(GetEnumValue(DayOfWeek.Saturday));
        }
    }
};

