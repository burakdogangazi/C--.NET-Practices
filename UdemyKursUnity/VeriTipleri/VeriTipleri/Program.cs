using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 3;
            long sayi2 = 95;
            float vırgullu = 3.4f;// float için belirtmen lazım doubleda gerek yok
            double vurgullu2 = 5.23;
            decimal para = 2.22222M;// PARA DA M EKLEMEK GEREKİYOR.
            char karakter = 'a';
            bool sayiVarMi = false;
            DateTime tarih = DateTime.Now;
            String metin = "Merhaba dünya!";
            string metin2;
            metin2 = "Merhaba tr!";

            int s1, s2=4, s3=7, s4 = 7;// s1 değer vermedik mesela program çalışmaz değer verilmediği için

            s1 = 5;
            Console.WriteLine(metin);

            Console.WriteLine(karakter);

            Console.WriteLine(vurgullu2);


            Console.WriteLine()


            Console.ReadLine();// console kapanmasını engeller.



        }
    }
}
