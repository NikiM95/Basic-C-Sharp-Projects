using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create a class called Employee and have it inherit from the Person class
    public class Employee : Person
    {
        //Give the class a property called Id and have it to int data type
        public int Id { get; set; }
        // Implement the SayName() method inside of the Employee class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
