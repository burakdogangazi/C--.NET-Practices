using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[] { 5, 2, 6, 20, 1, 222, 13 };
            //int min = dizi[0], max = dizi[0];

            //for(int i = 0; i < dizi.Length; i++)
            //{
            //    if(min > dizi[i])
            //    {
            //        min = dizi[i];
            //    }

            //    if( max < dizi[i])
            //    {
            //        max  = dizi[i]
            //    }
            //}

            //Console.WriteLine("{0} en büyük eleman ve {1} en küçük eleman",min,max)


            int[] sayilar = new int[10];

            Random random = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = random.Next(1, 200);
            }

            //a
            int sayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > 100)
                {
                    sayac++;
                }

            }
            Console.WriteLine(sayac);

            //b
            int ortalama = 0, toplam = 0, sayacB = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 150)
                {
                    toplam += sayilar[i];
                    sayacB++;

                }
            }
            ortalama = toplam / sayacB;

            //c
            int ciftsayilarsayaci = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    ciftsayilarsayaci++;
                }
            }

            // girilen kelimeyi harf harf alt alta yazalım

            //string giris = Console.ReadLine();

            //foreach(char karakter in giris)
            //{
            //    Console.WriteLine(karakter);
            //}

            // GİRİLEN METNİ TERSTEN yazdırma

            string metin = Console.ReadLine();

            for (int i = metin.Length -1; i >= 0; i--)
            {

                Console.Write(metin[i]);
            }



        }
    }
}
