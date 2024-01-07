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
            Cat cat = new Cat() { weight = 3, lenght = 5, name = "pisi" }; // cat classı boş ama animal türediği için onun özelliklerine erişebildik
            cat.lenght = 9;
            cat.runSpeed = 20;
            cat.sound = "Miyav!";

            Console.WriteLine(cat.GetProperties());
            Console.ReadLine();

            Bird bird = new Bird() { lenght = 3, flyDistance = 1, flySpeed = 10, name = "minik kuş" };

            Console.ReadLine();

        }
    }
}
