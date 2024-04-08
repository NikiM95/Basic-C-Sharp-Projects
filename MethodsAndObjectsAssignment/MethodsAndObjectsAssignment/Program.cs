using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and Initialize and Employee object
            Employee name = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            name.SayName();
            Console.ReadLine();
        }
    }
}
