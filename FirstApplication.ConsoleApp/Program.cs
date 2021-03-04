using System;
//using FirstApplication.ConsoleHelper;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and your age is {age}");
            Console.WriteLine("Please enter your birthday:");
            string birthday = Console.ReadLine();
            Console.WriteLine($"Your birthday is " + birthday);
            Console.ReadLine();
        }
                          
    }
}
