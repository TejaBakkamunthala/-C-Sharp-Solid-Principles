using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES1
{
    public class ISPWorker
    {
    }

    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();
    }

    public interface ISleepable
    {
        void Sleep();
    }

   public class Worker1: IWorkable,IFeedable,ISleepable
    
    { 
        public void Eat()
        {
            Console.WriteLine("Eatingg");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public void Work()
        {
            Console.WriteLine("Workingg");
        }

    
    }

    public class Robot1 : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot Workingg");
        }
    }

}
