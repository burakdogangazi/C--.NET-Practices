using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // metin içerisinde kaç cümle var?

            Console.WriteLine("Bir cümle giriniz");
            string metin = Console.ReadLine();
            int kelimeSayisi = kelimeSayisiBul(metin);

            Console.WriteLine("Cümledeki kelime sayisi {0}", kelimeSayisi);
            Console.ReadLine();

            //Params

            int toplam2 = Topla(3,4,6,7,8,9,9,11);
            Console.WriteLine(toplam2);// params console write line gibi istediğin kadar yazıyorsubn

        }

        private static int kelimeSayisiBul(string metin)
        {
            //boşlukları say her boşlukta sayacı arttır.
            int sayac = 1;
            foreach(char karakter in metin)
            {
                if(karakter == ' ')
                {
                    sayac++;
                }
            }

            return sayac;
        }
   
        static int Topla(params int[] sayi)
        {
            int toplam = 0

            for(int i = 0; i < sayi.lenght; i++)
            {
                toplam += sayi[i];
            }

            return toplam;
        }
    }
}
