using System;

namespace Income_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate: 45");
            Console.ReadLine();
            Console.WriteLine("Hours worked per week: 40");
            Console.ReadLine();
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate: 55");
            Console.ReadLine();
            Console.WriteLine("Hours worked per week: 35");
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 1:");
            Console.ReadLine();
            int Person1Hr = 45;
            int Person1HpW = 40;
            int Person1AnnualSalary = Person1Hr * Person1HpW * 52;
            Console.WriteLine(Person1AnnualSalary);
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2:");
            Console.ReadLine();
            int Person2Hr = 55;
            int Person2HpW = 35;
            int Person2AnnualSalary = Person2Hr * Person2HpW * 52;
            Console.WriteLine(Person2AnnualSalary);
            Console.ReadLine();
            Console.WriteLine("Person 1 makes more money than Person 2?");
            Console.ReadLine();
            bool higherSalary = Person1AnnualSalary > Person2AnnualSalary;
            Console.WriteLine(higherSalary);
            Console.ReadLine();
        }
    }
}
