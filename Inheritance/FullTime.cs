using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class FullTime : Employee
    {
        /*Constructor using "base (parent) class"*/
        public FullTime(string firstName, string lastName, string phoneNumber, decimal salaryRate, int vacationDays)
            :base(firstName, lastName, phoneNumber) 
        {
            SalaryRate = salaryRate;
            VacationDays = vacationDays;
        }

        /*PROPERTIES*/
        public decimal SalaryRate
        {
            get;
            set;
        }

        public int VacationDays
        {
            get;
            set;
        }

        /*We print out information about the class in console windows, form application*/
        public override string ToString()
        {
            return FirstName + " " + LastName + " is full time";
        }

        public override void PayRoll()
        {
            Console.WriteLine("This employee has a salary {0:C}", SalaryRate);
        }

    }
}
