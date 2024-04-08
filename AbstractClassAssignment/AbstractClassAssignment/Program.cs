using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and Initialize and Employee object
            Employee name = new Employee() { firstName = "Sample", lastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            name.SayName();
            Console.ReadLine();
        }
    }
}
