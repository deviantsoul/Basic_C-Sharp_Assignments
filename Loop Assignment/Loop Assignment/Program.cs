using System;

namespace Loop_Assignment
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Welcome to Hansen's 2077 Lottery!");
            //Console.ReadLine();
            //Console.WriteLine("Current Jackpot Price is $1,000,000,000. Tonight might be your lucky night!");
            //Console.ReadLine();
            //Console.WriteLine("Please enter your 6 digit ticket number: ");
            //int ticketNumber = Convert.ToInt32(Console.ReadLine());
            //bool jackpotPrize = ticketNumber == 444555;

            //do
            //{
            //    switch (ticketNumber)
            //    {
            //        case 445566:
            //            Console.WriteLine("You have 2 numbers matching. You have won $10.00. I hope you're happy?");
            //            Console.WriteLine("Please enter another 6 digit ticket number. I hope you win this time.");
            //            ticketNumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 444666:
            //            Console.WriteLine("You have 3 numbers matching. You have won $100,000.00. I hope you're happy?");
            //            Console.WriteLine("Please enter another 6 digit ticket number. I hope you win this time.");
            //            ticketNumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 444566:
            //            Console.WriteLine("You have 2 numbers matching. You have won $1,000,000.00. I hope you're happy?");
            //            Console.WriteLine("Please enter another 6 digit ticket number. I hope you win this time.");
            //            ticketNumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 444556:
            //            Console.WriteLine("You have 2 numbers matching. You have won $10,000,000.00. I hope you're happy?");
            //            Console.WriteLine("Please enter another 6 digit ticket number. I hope you win this time.");
            //            ticketNumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 444555:
            //            Console.WriteLine("Congratulations! You have won $1B! Remember this is year 2077 where inflation really matters!");
            //            Console.WriteLine("Thank you for gambling with us worth total $2B. Call us right away!");
            //            jackpotPrize = true;
            //            break;

            //        default:
            //            Console.WriteLine("Sorry. Better luck next time. Are you not ashamed of yourself? Gambling for 1 billion instead of working for it?");
            //            Console.WriteLine("Please enter another 6 digit ticket number. I hope you win this time.");
            //            ticketNumber = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //while (!jackpotPrize);

            //Console.ReadLine();

            //TUTORIAL STRINGS------------------------------------------------------------
            //string name = "Hansen";
            //string quote = "The man said, \"Hello\", " + name + ". \n Hello on a new line. \n \t Hello on a tab.";
            //string filename = "C:\\users\\Hansen";
            ////@ is used to tell the script that inbetween quotation marks are part of the script
            //string atFilename = @"C:\users\Hansen";
            //bool trueOrfalse = name.Contains("n");
            //trueOrfalse = name.EndsWith("s");

            ////to search for properties of a string or number
            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(filename);
            //Console.WriteLine(atFilename);
            //Console.WriteLine(quote);
            //Console.WriteLine(trueOrfalse);
            //Console.WriteLine(length);
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Hansen");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
