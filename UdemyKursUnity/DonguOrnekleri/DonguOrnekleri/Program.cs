using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonguOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // x den y  ye kadar olan çift sayıların toplamını bulan bir program yazınız.


            //Console.WriteLine("Lütfen x  girin");
            //int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen y  girin");
            //int y = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;

            //for(int i = x; i <= y; i++)
            //{
            //    if( i % 2 == 0)
            //    {
            //        toplam += i;

            //    }
            //}
            //Console.WriteLine("Toplam : " + toplam);



            //üst hesaplayan programı yazınız.

            //Console.WriteLine("Taban girin ");
            //int taban = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Üst girin ");
            //int ust = Convert.ToInt32(Console.ReadLine());

            //int sonuc = taban;
            //for(int i = 0; i < ust; i++)
            //{
            //    sonuc *= taban;
            //}

            //Console.WriteLine("Sonuç : " + sonuc);

            //Console.ReadLine();


            //Faktoriyel programı

            //Console.WriteLine("Sayı girin ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int fakt = 1;

            //for(int i = 2; i  <= sayi; i++)
            //{
            //    fakt *= i;
            //}
            //Console.WriteLine("Sonuc " + fakt);

            //Console.ReadLine();




            // Tahmin 3 haklı program

            //int tahminHakki = 3;

            //Random random = new Random();

            //int tutulanSayi = random.Next(1, 10);

            //for(int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine(i + ". tahmin hakkınızı giriniz : ");
            //    int soylenenSayi = Convert.ToInt32(Console.ReadLine());
            //     if(tutulanSayi == soylenenSayi)
            //    {
            //        Console.WriteLine("Doğru bildiniz tebrikler");
            //        break;
            //    }
            //    else
            //    {
            //        tahminHakki -= 1;
            //        if(tahminHakki == 0)
            //        {
            //            Console.WriteLine("tahmin hakkınız kalmadı kaybettiniz.");
            //        }
            //        continue;
            //    }

            //}

            //Console.ReadLine();


            // girilen  bir sayının iki sayının karesi toplamı şeklinde yazılıp yazılamayacağını bulan program

            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayi; i++)
            {
                for(int x = 0; x < sayi; x++)
                {
                    if (i * i + x * x == sayi)
                    {
                        Console.WriteLine(i + "*"+ i+ "+"+ x + "*" + x + " şeklinde yazılabilir.");
                        Console.WriteLine("{0} x {0} + {1} x {1} şeklinde yazılabilir",i,x)
                    
                    }
                }
            }



        
        }
    }
}
