using System;

namespace SF_Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();           

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your birtday ");
            string birtday = Console.ReadLine();

            Console.Write("What is your favorit day of week?");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Name = {name}\nAge = {age}\nBirtday = {birtday}\nFavorit day = {day}");
        }
    }
}
