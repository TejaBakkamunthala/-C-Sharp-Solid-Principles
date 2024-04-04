using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES1
{
    public class SRPEmployee
    {

    }
        public class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }

        public class SalaryCalculator
        {
            public decimal CalculateSalary(Employee employee)
            {
            Console.WriteLine("Calculate Salary");
            return employee.Salary;
            }
        }

        public class EmployeeRepository
        {
            public void SaveToDatabase(Employee employee)
            {
            Console.WriteLine("Save TO DataBase");
            Console.WriteLine();
        }
        }

        public class EmailService
        {
            public void SendEmailNotification(Employee employee)
        {
            Console.WriteLine("Send Email Notification");
        }
        }
    }
