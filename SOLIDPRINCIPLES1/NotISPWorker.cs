using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES1
{
    internal class NotISPWorker
    {
    }
    public interface IWorker
    {
        void Work();
        void Eat();
        void Sleep();
    }

    public class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }

    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }
        public void Eat()
        {

        }
        public void Sleep()
        {

        }

        // Robots don't eat or sleep
    }


}
