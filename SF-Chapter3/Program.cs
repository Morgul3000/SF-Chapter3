using System;

namespace SF_Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Egor";
            byte MyEge = 45;
            bool HaveIPet = true;
            double MyShoeSize = 45.5;

            Console.WriteLine($"My name is {MyName}.");
            Console.WriteLine($"My age is {MyEge}.");
            Console.WriteLine($"Do i have is Pet? {HaveIPet}.");
            Console.WriteLine($"My shoe size is {MyShoeSize}.");
        }
    }
}
