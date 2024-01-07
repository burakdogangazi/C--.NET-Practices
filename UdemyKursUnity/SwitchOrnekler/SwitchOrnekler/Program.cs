using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {

            string gun = Console.ReadLine();

            switch (gun)
            {

                case "Pazartesi":
                    Console.WriteLine("0derece");

                    break;

                case "Salı":
                    Console.WriteLine("1derece");
                    break;

                
                default:
                    Console.WriteLine("Bugun için bir tahmin yok.")
                    break;
            }

        }
    }
}
