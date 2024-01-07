using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan kullanıcı girdisini alma

            // string girdi = Console.ReadLine();

            //int sayi;

            //Console.WriteLine("Merhaba lütfen bir sayı girin:");

            //string girdi = Console.ReadLine();

            //sayi = Convert.ToInt32(girdi);

            //Console.WriteLine(sayi + 2);

            //Console.ReadLine();
            //---------------------------------------------


            //Kullanıcıdan alınan sayının karesini hesaplama

            int sayi;

            Console.WriteLine("Sayıyı giriniz :");

            string girdi = Console.ReadLine();

            sayi = Convert.ToInt32(girdi);

            Console.WriteLine("Sayının karesi : "+ sayi * sayi);

            

            //------------------------------------------------


            //Toplama uygulaması

            int sayi1, sayi2;

            Console.WriteLine("Lütfen sayi1 giriniz  :");

            string girdi1 = Console.ReadLine();

            Console.WriteLine("Lütfen sayi2 giriniz  :");

            string girdi2 = Console.ReadLine();

            sayi1 = Convert.ToInt32(girdi1);
            sayi2 = Convert.ToInt32(girdi2);

            //int toplam = Convert.ToInt32(girdi1) + Convert.ToInt32(girdi2);
            Console.WriteLine("Sonuç = " + (sayi1 + sayi2));


            //--------------------------------------------

            //3-Tasarruf Hesaplayıcısı

            int ampulSayisi, saat;
            float fiyat = 2;

            Console.WriteLine("TASARRUF HESAPLAMA PROGRAMNINA HOŞGELDİNİZ..");
            Console.WriteLine("Kaç ampul kullanıyorsunuz?");

            //string ampul = Console.ReadLine();

            ampulSayisi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç saat kullanıyorsunuz ?");

            saat = Convert.ToInt32(Console.ReadLine());

            float faturaTutari = ampulSayisi * saat * fiyat;

            float tasarrufluTutar = faturaTutari * 80 / 100;

            Console.WriteLine("Normal Ampul Tutarı " + faturaTutari);
            Console.WriteLine("Tasarruflu Tutar : " + tasarrufluTutar);

            Console.ReadLine();






        }
    }
}
