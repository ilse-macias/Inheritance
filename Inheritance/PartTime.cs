using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PartTime : Employee
    {
        /*Constructor using "base (parent) class"*/
        public PartTime(string firstName, string lastName, string phoneName, decimal hourlyRate)
            :base(firstName, lastName, phoneName)
        {
            HourlyRate = hourlyRate;
        }

        /*Properties*/
        public decimal HourlyRate
        {
            get;
            set;
        }

        /*We print out information about the class in console windows, form application*/
        public override string ToString()
        {
            return FirstName + " " + LastName + "  is part time";
        }

        public override void PayRoll()
        {
            Console.WriteLine("This employee has a salary {0:C} per hour", HourlyRate);
        }

    }
}
