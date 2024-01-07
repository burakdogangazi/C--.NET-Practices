using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSOLE. KULLANIRSAN ctaşıayamazsın başka yere o yüzden yan classlarda animal gibi console.kullanma
            Animal cat = new Animal();
            cat.name = "Pisicik";
            cat.weight = 4;
            cat.gender = 1;

            Console.WriteLine(cat.GetAnimalProperties());

            Animal bird = new Animal();
            bird.name = "Kanarya";
            bird.weight = 1;
            bird.gender = 1;

            Console.WriteLine(bird.GetAnimalProperties());

            Animal dog = new Animal();
            Console.WriteLine(dog.GetAnimalProperties());



        }
    }
}
