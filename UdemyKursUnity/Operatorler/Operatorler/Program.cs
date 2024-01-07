using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 5;
            int sayi2 = 11;

            int toplam = sayi + sayi2;

            int fark = sayi - sayi2;

            int carpım = sayi * sayi2;

            int bolum = sayi2 / sayi;


            float s1 = 18;
            float s2 = 5;
            float sonuc = s1 / s2;
            //Console.WriteLine(toplam);
            //Console.WriteLine(fark);
            //Console.WriteLine(carpım);
            //Console.WriteLine(bolum);// 11/5 = 2 verir
            //Console.WriteLine(sonuc);// float sonuc 3.6 çıkar 

            int yeniSayi = 1;

            yeniSayi++; // sayıyı 1 arttırır.
            ++yeniSayi;

            int azaltmaSayisi = 5;

            azaltmaSayisi--;
            azaltmaSayisi--;
            Console.WriteLine(azaltmaSayisi--);// 3

            int sayi9 = 10;

            sayi9 += 10;

            //sayi9 = sayi9 + 10;


            String a = "merhaba";

            String b = " hoşcakal";

            String toplamları = a + b;

            Console.WriteLine(toplamları);


            Console.ReadLine();


        }
    }
}
