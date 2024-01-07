using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul4FonksiyonVeProcedur
{
    class Program
    {
        // çoklu işlem yaparsa procedur tek işlem fonksiyon
        // ReadLine, ReadKey bir sürü mevzusu var demekki procedur
        private int hesapla(int deger1, int deger2)
        {
            int sonuc;
            sonuc = deger1 + deger2;
            return sonuc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = 10;
            sayi2 = 40;
            sonuc = hesapla(sayi1, sayi2);
        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    String kelime1, kelime2;
        //    kelime1 = " gazi fen";
        //    kelime2 = "bmt214";
        //    hesapla(kelime1, kelime2);
        //}

        //private void hesapla(String deger1, String deger2)
        //{
        //    MessageBox.Show("Birinci deger = " + deger1);
        //    MessageBox.Show("İkinci deger = " + deger2);
        //}


        //private int hesapla1(int deger)
        //{
        //    int carpim = 1;

        //    if(deger > 1)
        //    {
        //        carpim = deger * hesapla1(deger - 1);
        //    }


        //}



        static void Main(string[] args)
        {

            int[] dizideger = new int[5];

            //Math.Log(deger, 10);// 10 tabanında log alır
            //Math.Max(deger, sayi);// deger ve sayı degiskenlerinden büyük olanı çagırır
            //Math.Min(deger, sayi);// kucugu cagırır
            //Math.PI;
            //Math.Pow(a,2)//a değişkneninin 2.cu kuvvetini al demek
            //Math.Abs(deger); //sayının pozitif değeri elde EDİLİR 
            //Math.Sqrt(a);// karekök alır

            //String.Compare(kıyaslanandeger, anametin);
            // birinci parametre ikinicide var mı diye bakılır varsa -1 yoksa +1 iki veri aynıysa 0


            //String.Concat(ilkmetin, "", ikincimetin); metinleri birişeltirir ikiden fazla olabilir

            // String.Copy(metin);// metin değişken değerini kopyalar.

            // String.Empty// içeriği temizler

            // String.Equals(birinci,ikinci)// girilenlerin aynı olup olmadğını kontrol eder aynısa true değilse false

            //String metin;
            //metin.Insert(9, "merhbaba");//metin değiş 9.cu karakterinden sonra merhabayı ekle demektir.

            //metin.Length// karakter sayısı

            //metin.Replace(".", "_"); ç ile _ yer degistir.


            // metin.Substring(5,3)// 5. karakterinden sonra 3 karakter kes 
            //metin.ToUpper(); küçükleri büyük yapar
            //metin.ToLower(); büyükleri küçük yapar


            //metin.Trim(); // boşlukları kaldırır.

            //DateTime zaman = DateTime.Now;// zaman değişkneini 0 anki zamanı atar

            //DateTime tarih;
            //tarih.DayOfWeek;//haftanın hangi gününe geldiğini gösterir.

            //Round ondalığı en yakın tam sayıya çevirir Ceiling yukarı yuvarlama tamsayı ve floor aşağı yuvarlama tamsayı

            //DateTime zamandogum = new DateTime();




            Console.ReadLine();

        }
        
    }
}
