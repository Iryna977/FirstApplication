using System;
//using FirstApplication.ConsoleHelper;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
       static void Main(string[] args)
        {
            string MyName = "Iryna";
            byte MyAge = 33;
            bool HaveIApet = false;
            double MyShoeSize = 36;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
            Console.ReadKey();
        }
    }
}
