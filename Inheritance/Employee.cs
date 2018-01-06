using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Employee
    {
        /*Constructor*/
        public Employee(string firstName, string lastName, string phoneNumber)
        {
            //Property = value;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        /*PROPERTIES*/
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        /*Abstract method*/
        public abstract void PayRoll();
    }
}
