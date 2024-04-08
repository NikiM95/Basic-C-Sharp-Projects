using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate the MathOperation class
            MathOperation mathOperation = new MathOperation();

            // Call the PerformOperation method passing in two numbers
            mathOperation.PerformOperation(5, 20);


            // Call the PerformOperation method specifying parameters by name
            mathOperation.PerformOperation(num1: 7, num2: 30);

        }
    }
}
