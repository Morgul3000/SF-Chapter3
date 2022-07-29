using System;

namespace SF_Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your fovorit colore");
            string color = Console.ReadLine();

            if(color == "red") 
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your favorit color is red");
            }
            else if(color == "green") 
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Your favorit color is green");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("I din't now what is a color...");
            }   
        }
    }
}
