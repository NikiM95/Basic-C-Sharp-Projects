using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create an abstract class called Person and give it two properties, each of string data type
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Create a method called SayName() 
        public abstract void SayName();
    }
}
