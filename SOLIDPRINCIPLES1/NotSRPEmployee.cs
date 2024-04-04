using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES1
{
    public class NotSRPEmployee
    {
        public string Name { get; set; }
        public int age {  get; set; }
        public int salary { get; set; }

        public void CalculateSalary()

        {
            Console.WriteLine("Salary Calculation");
        }

        public void SaveToDatabase()
        {
            Console.WriteLine("Save To DataBase");
        }

        public void SendEmailNotification()
        {
            Console.WriteLine("Send Email Notification");
        }
    }



}
