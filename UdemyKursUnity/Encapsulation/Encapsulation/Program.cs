using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectange rec = new Rectange();
            rec.a = 3;
            rec.b = 5;

            Console.WriteLine(rec.CalculateArea());
            Console.ReadLine();

        }
    }
}
