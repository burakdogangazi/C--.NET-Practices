using System; // ana kütaphane
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul1VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            bool dogruyanlis = true;//2 byte

            byte pozdeger = 35; // 0 255 1byte

            char s = 'a'; //aslında sayı değerlidir ascıı tablosunda 2 byte

            decimal Yuksekdeger = 1515231;//16 bayt maks 29 haneli sayı tutar

            double ondalikli = 5.233; // 8 byte ondalıklı

            int b = 35;// 4 byte
             
            long c = 31231; // 8 byte

            short d = 13; // 2 byte

            string karakter = "Merhaba";

            float l = 312.23f;

            // başında unsigned bulunanlar negatif olamaz
            ulong  o = 12315;// 8 bayt

            uint p = 123123; //4 byte

            ushort h = 1233; //2 byte 

            sbyte  v = 125; // -128 ile +127


            const double PI = 3.141519;
            const int deger = 31;

            Console.WriteLine("1.Örnek");//using System üstte yazdığımız için başına System. koymamıza gerek kalmadı.

            // konsol direk kapanmasın diye

            Console.ReadLine();

        }
    }
}
