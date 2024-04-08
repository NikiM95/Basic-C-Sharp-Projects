using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;
            if (emp1 is null || emp2 is null)
                return false;
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
        // Override Equals method for consistency
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Employee))
                return false;

            Employee emp = (Employee)obj;
            return this.Id == emp.Id;
        }

        // Override GetHashCode method to maintain consistency with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


    }
}
