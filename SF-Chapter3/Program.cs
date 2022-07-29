using System;

namespace SF_Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your fovorit colore");
            string color = Console.ReadLine();

            switch(color) 
            {
                case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your favorit color is red");
                    break;

                case "green": 
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your favorit color is green");
                    break;

                case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your favorit color is syan");
                    break;

                default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your favorit color is yellow");
                    break;
            }   
        }
    }
}
