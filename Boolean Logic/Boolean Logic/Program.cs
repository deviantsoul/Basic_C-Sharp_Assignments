﻿using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            //string name, input;
            //int age;
            //int yourTicket;
            //Console.WriteLine("Car Insurance Qualifier");
            //Console.ReadLine();
            //Console.WriteLine("What is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine("What is your age?");
            //input = Console.ReadLine();
            //age = Convert.ToInt32(input);
            //Console.ReadLine();
            //Console.WriteLine("Have you ever had a DUI? Please answer Yes or No.");
            //Console.ReadLine();
            //bool Yes = true;
            //bool No = false;
            //Console.WriteLine("How many speeding tickets do you have?");
            //input = Console.ReadLine();
            //yourTicket = Convert.ToInt32(input);
            //Console.ReadLine();
            //bool Qualified = (age > 15) && Yes && (yourTicket <= 3);
            //Console.WriteLine("Qualified? - " + Qualified);
            //Console.ReadLine();


            //BRANCHING ---------------------------------------------------------------------------------
            //if (2 == 1) 
            //{
            //    Console.WriteLine("1 equals 1!");
            //}
            //else
            //{
            //    Console.WriteLine("1 does not equal 1");
            //}
            //Console.ReadLine();

            //string name = "Hansen";
            //if (name == "Hansen") 
            //{
            //    Console.WriteLine("Your name is Hansen.");
            //}

            //else
            //{
            //    Console.WriteLine("Your name is unbearable!");
            //}
            //Console.ReadLine();

            //string name = "Hansen";

            //if (name == "Hansen")
            //{
            //    Console.WriteLine("Your name is Hansen.");
            //}

            //else if (name == "Ivy")
            //{
            //    Console.WriteLine("Your name is not Hansen. Who are you?");
            //}

            //else
            //{
            //    Console.WriteLine("Your name is not Hansen nor Ivy, then who the heck are you?");
            //}
            //Console.ReadLine();

            //string name = "Hansen";

            //if (name != "Ivy")
            //{
            //    Console.WriteLine("Your name is not Hansen");
            //}
            //Console.ReadLine();

            //if ( 1 != 2)
            //{
            //    Console.WriteLine("All is right with the universe.");
            //}
            //else
            //{
            //    Console.WriteLine("We live in a bizarro world.");
            //}
            //Console.ReadLine();

            //int num1 = 12;
            //int num2 = 14;
            //if (num1 > num2)
            //{
            //    Console.WriteLine("The first number is larger.");
            //}
            //else
            //{
            //    Console.WriteLine("The second number is larger.");
            //}
            //Console.ReadLine();

            //int age = 19;
            //if (age > 21)
            //{
            //    Console.WriteLine("No you may not purchase that bottle of wine.");
            //}
            //else
            //{
            //    Console.WriteLine("That will be $23.71");
            //}
            //Console.ReadLine();

            //int age = 20;
            //if (age <= 20)
            //{
            //    Console.WriteLine("No you may not purchase that bottle of wine");
            //}

            //else
            //{
            //    Console.WriteLine("There you go!");
            //}
            //Console.ReadLine();

            //int age = 20;
            //if (age >= 25)
            //{
            //    Console.WriteLine("Yes you may rent a car from us.");
            //}
            //else
            //{
            //    Console.WriteLine("No you may not rent a car from us.");
            //}
            //Console.ReadLine();

            //int num1 = 7;
            //int num2 = 18;
            //int num3 = 12;
            //if (num2 > num1 && num3 < num2)
            //{
            //    Console.WriteLine("The second number is larger than the others.");
            //}
            //Console.ReadLine();

            //int num1 = 7;
            //if (true && true && true && true && num1 == 20)
            //{
            //    Console.WriteLine("Everything was true!");
            //}
            //else
            //{
            //    Console.WriteLine("There was a false somewhere!");
            //}
            //Console.ReadLine();

            //int packageWeight = 50;
            //int packageLength = 25;
            //if (packageWeight > 40 && packageLength > 20)
            //{
            //    Console.WriteLine("This package is too big to ship.");
            //}
            //Console.ReadLine();

            //int num1 = 7;

            //if (num1 < 7 || num1 == 12)
            //{
            //    Console.WriteLine("At least one value is true.");
            //}

            //else
            //{
            //    Console.WriteLine("No value is true.");
            //}

            //if (num1 == 12 || num1 == 18 || num1 == 20 || num1 == 7)
            //{
            //    Console.WriteLine("Something is true.");
            //}
            //Console.ReadLine();

            //string role = "admin";
            //if (role == "admin" || role == "administrator")
            //{
            //    Console.WriteLine("You may have access to the entire software system.");
            //}
            //Console.ReadLine();

            //int num1 = 7;
            //if (num1 < 18 && ((num1 == 7) || num1 == 2) && ((num1 == 8 && num1 > 20) || (num1 < 20 && num1 > 2)))
            //{
            //    Console.WriteLine("Wow, that was confusing.");
            //}
            //Console.ReadLine();

            //TERNARY OPERATOR --------------------------------------------------------------
            //int num1 = 7;
            //int num2 = 12;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greather than num2";
            //Console.WriteLine(result);
            //Console.ReadLine();

            //Branching Video-----------------

            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temperature." : "It is not room temperature.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is the exact room temperature.");
            //}

            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}

            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}

            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong...");
            //}
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an amazing number." : "You do not have an awesome number.";

            //Console.WriteLine(result);
            //Console.ReadLine();
        }
    }
}
