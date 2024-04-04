using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLIDPRINCIPLES1.NotOCPShapes;

namespace SOLIDPRINCIPLES1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //NotSRPEmployee nse=new NotSRPEmployee();
            //nse.CalculateSalary();
            //nse.SendEmailNotification();
            //nse.SaveToDatabase();

            //Console.WriteLine();
            //Employee emp=new Employee();
            //SalaryCalculator sc=new SalaryCalculator();
            //sc.CalculateSalary(emp);

            //EmployeeRepository er=new EmployeeRepository();
            //er.SaveToDatabase(emp);

            //EmailService es=new EmailService();
            //es.SendEmailNotification(emp);



            //NOT USED OPEN CLOSED PRINCIPLE
            //Circle c1 = new Circle(20);
            //Console.WriteLine(c1.CalculateArea());

            //Rectangle r1 = new Rectangle(20,30);
            //Console.WriteLine(r1.CalculateArea());

            //Console.WriteLine("OPEN CLOSE PRINCIPLE");
            ////USED OPEN CLOSE PRINCIPLE
            //Circle1 c2 = new Circle1();
            //c2.Radius = 20;

            //Console.WriteLine(c2.CalculateArea());
            //Rectangle1 r2 = new Rectangle1();
            //r2.Width = 20;
            //r2.Height = 20;
            //Console.WriteLine(r2.CalculateArea());

            //Triangle1 t1 = new Triangle1();
            //t1.Base= 10;
            //t1.Height = 10;
            //Console.WriteLine(t1.CalculateArea());


            //Console.WriteLine("LISKOV SUBSTITUTION PRINCIPLE");
            //Shape11 shape1 = new Circle11();
            //shape1.Draw();

            //Shape11 shape2 = new Square11();
            //shape2.Draw();


            Console.WriteLine("Not  using Integration Segragation Principle");
            Worker worker = new Worker();
            worker.Eat();
            worker.Work();
            worker.Sleep();

            Robot robot = new Robot();
            robot.Eat();
            robot.Work();
            robot.Sleep();


            Console.WriteLine("  using Integration Segragation Principle");


            Worker1 worker1 = new Worker1();
            worker1.Eat();
            worker1.Work();
            worker1.Sleep();

            Robot1 robot1 = new Robot1();
            
            robot1.Work();
            






        }
    }
}
