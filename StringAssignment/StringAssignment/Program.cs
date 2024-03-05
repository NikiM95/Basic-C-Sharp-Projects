using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Nicole";
            string lastName = "Mongan";
            string address = "Tuam";

            Console.WriteLine("My name is " + firstName + " " + lastName + " and I live in " + address + ". \n");


            firstName = firstName.ToUpper();
            Console.WriteLine(firstName +"\n");
           

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Niki \n");
            sb.Append("I am 29 year's old \n");
            sb.Append("and I live in Tuam");
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
