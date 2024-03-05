using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_QuoteApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n");
          
            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());
          
            if (packWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());
           
                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Please enter the package length:");
                int packLength = Convert.ToInt32(Console.ReadLine());
                
                if (packWidth + packHeight + packLength > 50)
                {
                    Console.WriteLine("Package is too big to be shipped vis Package Express.");
                }
                else
                {
                    decimal result = ((packWidth * packHeight * packLength) * packWeight / 100);
                    Console.WriteLine(result);
                    Console.WriteLine("Your estimated total for shipping this package is: £" + result + "\n");
                    Console.WriteLine("Thank you");
                } 
            }
            Console.ReadLine();
        }
    }
}
