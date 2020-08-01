using System;

namespace _4_6_Lab_Array_To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // defining arrays
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] tasks = new string[7];
            // cycle through each day of week capturing daily tasks
            for (int i=0; i<days.Length; i++)
            { 
                Console.WriteLine("Type in a new task for " + days[i]);
                tasks[i] = Console.ReadLine();
            }
            // print our the weekly day-task list
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i] +" : " + tasks[i]);
            }
        }
    }
}
