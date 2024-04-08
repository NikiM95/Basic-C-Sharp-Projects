using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Create a class called Person and give it two properties, each of string data type
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Create a void method called SayName() that takes no parameters & 
        // prints the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
