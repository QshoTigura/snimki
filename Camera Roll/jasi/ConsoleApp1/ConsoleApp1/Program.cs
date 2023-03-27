using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (a == "apple" || a == "kiwi" || a == "cherry" || a == "lemon" || a == "grapes")
            {
                Console.WriteLine("Fruit");
            }
            else if (a == "tomato" || a == "cucumber" || a == "pepper" || a == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}
