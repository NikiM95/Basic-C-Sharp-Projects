using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1 -> Multiple
            Console.WriteLine("Pick a number to multiple?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int answer = num1 * 50;
            Console.WriteLine(num1 + " * by 50 = " + answer);
            Console.ReadLine();

            //// 2 -> Add
            Console.WriteLine("Pick a number to add?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int answer2 = num2 + 25;
            Console.WriteLine(num2 + " + 25 = " + answer2);
            Console.ReadLine();

            //// 3 -> Divide
            Console.WriteLine("Pick a number to divide?");
            double num3 = Convert.ToInt32(Console.ReadLine());
            double answer3 = num3 / 12.5;
            Console.WriteLine(num3 + " / by 12.5 = " + answer3);
            Console.ReadLine();

            //// 4 -> Bool
            Console.WriteLine("Pick a number to check if it is greater than 50?");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = num4 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            // 5 -> Modulus
            Console.WriteLine("Pick a number?");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int answer5 = num5 % 7;
            Console.WriteLine(num5 + " % by 7 = " + answer5);
            Console.ReadLine();

        }

    }
}

