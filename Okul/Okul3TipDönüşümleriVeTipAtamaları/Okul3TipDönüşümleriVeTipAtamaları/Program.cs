using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul3TipDönüşümleriVeTipAtamaları
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i;
            //float f;
            //i = 10;
            //f = i;

            //Console.WriteLine(f);// 10 YAZAR
            // uyumsuz tipler arasında dönüşüm için cast işlemi yapılır

            //long l;
            //double d;
            //int u;
            //char ch;

            //l = 10000002343;
            //d = l;

            //Console.WriteLine("Double sonraki değer " + d);

            //d = 1.222223;

            //u = (int)d;

            //Console.WriteLine("1.2222223 ün int tipine dönüştürülmiş hali " + u);

            //u = 88;

            //ch = (char)u;

            //Console.WriteLine("ch değişkenine 88 atandıktan sonraki durum " + ch);//x




            //string strsayi = "15";

            //int isayi;

            //isayi = Convert.ToInt32(strsayi);
            //// short için int16 int için 32 long için int64 kullanılabilir.


            //string strsayi2 = "";

            //int isayi2 = 15;

            //strsayi2 = Convert.ToString(isayi);


            //double dPi = 3.1416;
            //double dYariCap;
            //double dAlan;
            //string strDeger;

            //Console.WriteLine("Yarıçap Değerini Giriniz:");

            //dYariCap = Convert.ToDouble(Console.ReadLine());

            //dAlan = dYariCap * dYariCap * dPi;

            //Console.WriteLine("Sonuç : " + dYariCap);

            /*strDeger = Console.ReadLine();

            dYariCap = Convert.ToDouble(strDeger);*/

            //x=x+1 x++; ...

            //int x = 10;
            //int y = ++x;// y = y + 1 ; y  = x
            //Console.WriteLine(y);//11


            //int x = 10;
            //int y = x++;// y = x ; y= y+1 
            //Console.WriteLine(y);//10

            // Bit düzeyinde işlem yapan operatörler!! bakılabilir.

            // x+=10;


            //int intGecmeNotu = 50;
            //int intVizeNotu, intFinalNotu;
            //double dbYilSonu;

            //Console.Write("Vize Notunu giriniz :");
            //intVizeNotu = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Final Notunu giriniz :");
            //intFinalNotu = Convert.ToInt32(Console.ReadLine());

            //dbYilSonu = (intVizeNotu * 0.40) + (intFinalNotu * 0.60);


            //if((dbYilSonu >= intGecmeNotu) && (intFinalNotu > 69))
            //{
            //    Console.WriteLine("Dersten Başarılısınız.");
            //}

            //else
            //{
            //    Console.WriteLine("Dersten Başarısızsınız");
            //}

            string karsilamaMesaji = "";

            int saat = DateTime.Now.Hour;

            switch (saat)
            {
                case 9:
                case 10:
                case 11:
                    karsilamaMesaji = "Günaydın";
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                    karsilamaMesaji = "İyiGünler";
                    break;
                case 16:
                case 17:
                    karsilamaMesaji = "İyi Akşamlar";
                    break;
                default:
                    karsilamaMesaji = "Merhaba";
                    break; 
            }

            Console.WriteLine(karsilamaMesaji);

            //// x = (a > b) ? a: b;
            //if(a > b)
            //{
            //    x = a;
            //}
            //else
            //{
            //    x = b;
            //}



            Console.ReadLine();



        }
    }
}
