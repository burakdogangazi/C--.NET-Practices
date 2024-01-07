using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayiKare = 2;
            Console.WriteLine(ToplamaYap(5, 9);
            Console.WriteLine(kareAl(5));
            Console.WriteLine(KupAl(ref sayiKare))
        }
    
         static int ToplamaYap(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }
        
        static int kareAl(int sayi)
        {
            return sayi * sayi;
        }

        static int KupAl(ref int sayi)
        {
            return sayi * sayi * sayi;

        }
        // ref anahtar sözcüğü referans yollar
        // int sayi = 5 dersen stackte tutlur değişken ve değer  aynı yerde tutulur.
        // string yazarsan mesela string metin = "ahmet" bu referans tipli değişkendir değişken stackte değer heap te tutulur.
        // int sayiKare = 9 yazdık sonra fonksiyona gönderdik onun kopyası oluşturulup onun üstünde işlem yapar.
        //
    
    }
}
