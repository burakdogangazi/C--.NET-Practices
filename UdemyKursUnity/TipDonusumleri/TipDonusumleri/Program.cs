using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            long buyukSayi = 9;

            long sayi3 = sayi;// hata vermez

            //int sayi5 = buyukSayi;// hata verir.

            int sayi5 = (int)buyukSayi;

            string a = "3";
            string b = "9";

            //Convert

            int toplam = Convert.ToInt32(a) + Convert.ToInt32(b);//12


            Console.WriteLine(a + b);//39


            Console.ReadLine();


        }
    }
}
