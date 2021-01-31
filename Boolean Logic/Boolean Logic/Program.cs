using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            string name, input;
            int age;
            int yourTicket;
            Console.WriteLine("Car Insurance Qualifier");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer Yes or No.");
            Console.ReadLine();
            bool Yes = true;
            bool No = false;
            Console.WriteLine("How many speeding tickets do you have?");
            input = Console.ReadLine();
            yourTicket = Convert.ToInt32(input);
            Console.ReadLine();
            bool Qualified = (age > 15) && Yes && (yourTicket <= 3);
            Console.WriteLine("Qualified? - " + Qualified);
            Console.ReadLine();
        }
    }
}
