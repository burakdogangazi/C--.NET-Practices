using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 2;

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("sayı 1");
                    break;
                case 2:
                    Console.WriteLine("sayı 2");
                    goto case 4;
                    break;

                case 4:
                    Console.WriteLine("sayı 4 dür");
                    break;
                default:
                    Console.WriteLine("Sayı 1 ya da 2 değildir.");
                    break;
            }

        }
    }
}
