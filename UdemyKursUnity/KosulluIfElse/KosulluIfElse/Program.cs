using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulluIfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi >10)// if yaz 2 kere tab
            {
                Console.WriteLine("Sayı 10 dan büyük");
            }
            else if(sayi == 5)
            {

                Console.WriteLine("sayı 5 eşit");
            }

            else
            {
                Console.WriteLine("Sayı ondan küçük ya da eşit");
            }

            /*if (sayi == 9)
                Console.WriteLine("sayı 9");*/
        }
    }
}
