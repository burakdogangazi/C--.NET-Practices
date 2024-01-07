using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // listelerde boyut sınırı yok dizilerin aksine

            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(7);
            //sayilar.Remove(3) 3 ü çıkardı 3 ü sil demek
            //sayilar.RemoveAt(0) burda indeks şeklinde siler
            //int uzunluk = sayilar.Count;
            //sayilar.Clear(); tüm elemanları siler

           // sayilar.Contains(1); // 1 sayısını içeririyor mu

        }
    }
}
