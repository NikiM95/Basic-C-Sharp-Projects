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

            // Using polymorphism to Create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();
            Console.ReadLine();
        }
    }
}
