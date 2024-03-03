using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // PERSON 1
            Console.WriteLine("What is Person's 1 hourly rate of pay?");
            decimal hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours does Person 1 work?");
            decimal hrsWorked1 = Convert.ToInt32(Console.ReadLine());
            
            decimal weeklyPay1 = hourlyRate1 * hrsWorked1;
            decimal annualSalary1 = weeklyPay1 * 52;


            // PERSON 2
            Console.WriteLine("What is Person's 2 hourly rate of pay?");
            decimal hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours does Perosn 2 work?");
            decimal hrsWorked2 = Convert.ToInt32(Console.ReadLine());

            decimal weeklyPay2 = hourlyRate2 * hrsWorked2;
            decimal annualSalary2 = weeklyPay2 * 52;

            bool trueOfFalse = annualSalary1 > annualSalary2;

            Console.WriteLine(
                "Anonymous Income Comparison Program \n" +
                "Person 1 \n" +
                "Hourly Rate? \n" +
                hourlyRate1 + "\n" +
                "Hours Worked per week? \n" +
                hrsWorked1 + "\n\n" +
                "Person 2 \n" +
                "Hourly Rate? \n" +
                hourlyRate2 + "\n" +
                "Hours Worked per week? \n" +
                hrsWorked2 + "\n\n" +
                "Annual salary of Person 1: \n" +
                annualSalary1 + "\n" +
                "Annual salary of person 2: \n" +
                annualSalary2 + "\n" +
                "Person 1 makes more money than Person 2 \n" +
                trueOfFalse.ToString()
                ); ;
            Console.ReadLine();

        }
    }
}
