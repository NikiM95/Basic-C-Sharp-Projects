using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI violation? Please answer 'yes or no'.");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool answer = (age > 15 && DUI == "no" && tickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(answer);
            Console.ReadLine();
            



        }
    }
}
