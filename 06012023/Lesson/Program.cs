using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDays dayOfWeek = WeekDays.Friday;


            Console.WriteLine((int)dayOfWeek);

            int[] nums = { 2, 5, 3, 6 };

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            //var enumNames = Enum.GetNames(typeof(WeekDays));

            //foreach (var enumName in enumNames)
            //{
            //    Console.WriteLine(enumName);
            //}

            Console.WriteLine("Weekdays");
            foreach (var item in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(item + " - " + (byte)item);
            }


            byte dayNum;
            string dayStr;
            do
            {
                Console.WriteLine("Heftenin gununu secin:");
                dayStr = Console.ReadLine();
            } while (!byte.TryParse(dayStr,out dayNum) || !Enum.IsDefined(typeof(WeekDays),dayNum));

            var day = (WeekDays)dayNum;

            Console.WriteLine(day+" - "+(byte)day);

        }
    }
}
