using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Employee
            Employee employee1 = new Employee(1, "John", "Doe");
            Employee employee2 = new Employee(2, "Jane", "Smith"); 

            // Compare Employee objects and print the results
            Console.WriteLine("Comparing Employee objects:");
            Console.WriteLine($"Is Employee 1 equal to Employee 2 : {employee1 == employee2}");
            Console.WriteLine($"Is Employee 1 not equal to Employee 2 : {employee1 != employee2}");

            Console.ReadLine();
        }
    }
}
