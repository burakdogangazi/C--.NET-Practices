using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // ***************FOR*****************
            //int x = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= x; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //for(int i = 100; i >= 1; i--)
            //{
            //    Console.Write(i + " ");

            //}


            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int sayac = 0;

            //for(int i = 1; i < 100; i++)
            //{

            //    if(i % 5 == 0)
            //    {
            //        sayac++;
            //        if(sayac == 5)
            //        {

            //            Console.WriteLine(i);
            //            break;
            //        }


            //    }

            //}

            //***************ForEach Döngüsü****************

            //int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100, 150 };

            //foreach(int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //Console.ReadLine();

            //*************************While Döngüsü**************

            //int i = 1;
            //while (i < 100)
            //{
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(i * i);
            //    }
            //    i++;
            //}

            //********************Do While Döngüsü*******************
            // -1 yazana kadar sayı al ve ortalamasını göster..

            int toplam = 0, sayac = 0, ortalama = 0, giris = 0;

            do
            {
                Console.WriteLine("Çıkmak için -1 basın");
                giris = Convert.ToInt32(Console.ReadLine());

                if(giris != -1)
                {
                    toplam += giris;
                    sayac++;
                }
            }
            while (giris != -1);


            ortalama = toplam / sayac;
            Console.WriteLine("Ortalamanız:" + ortalama);
            Console.ReadLine();
        }
    }
}
