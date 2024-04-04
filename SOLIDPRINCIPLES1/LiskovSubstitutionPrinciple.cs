using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLES1
{
    public class LiskovSubstitutionPrinciple
    {
    }
    public class Shape11
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    public class Circle11 : Shape11
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Square11 : Shape11
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");

        }

    }

}