using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee 1
            string firstName = "Juan";
            string lastName = "Pérez";
            string phoneNumber = "664-123-4567";
            decimal salaryRate = 50000m;
            int vacationDays = 10;
            FullTime newEmployeeFullTime = new FullTime(firstName, lastName, phoneNumber, salaryRate, vacationDays);

           // Employee emo = new Employee(firstName, lastName, phoneNumber);

            //Employee 2
            string firstName2 = "Pepito";
            string lastName2 = "Toro";
            string phoneNumber2 = "123-456-7890";
            decimal hourlyRate = 15.00m;
            PartTime newEmployeePartTime = new PartTime(firstName2, lastName2, phoneNumber2, hourlyRate);

            /*Polymorphism*/
            List<Employee> list = new List<Employee>();
            list.Add(newEmployeeFullTime);
            list.Add(newEmployeePartTime);

            foreach(Employee employee in list)
            {
                Console.WriteLine(employee.ToString());
                employee.PayRoll();
            }
        }
    }
}
