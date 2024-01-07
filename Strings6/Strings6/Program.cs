using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string city = "Ankara";
            Console.WriteLine(city[0]);
            
            
            foreach(var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            string result = city + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));


            //String Metodları

            string sentence = "My name is Burak Doğan";

            var result2 = sentence.Length;

            var result3 = sentence.Clone(); // değeri kopyalar yeni referans oluşturur 

            var result4 = sentence.EndsWith("ü");

            var result5 = sentence.StartsWith("ü");

            var result6 = sentence.IndexOf("name"); // 3 döner bulamadığında -1

            var result7 = sentence.IndexOf(" "); // bulduğu ilk boşluk 2 

            var result8 = sentence.LastIndexOf(" "); // sondan arar 16 döner

            var result9 = sentence.Insert(0, "Hello, "); //indexe ekler

            var result10 = sentence.Substring(3,4); // 3. karakterden başlayarak hepsini alır
            // 3 ve 4 yazarsak 3.karakterden itibaren 4 tane al yani name olacaktır.

            var result11 = sentence.ToLower(); // hepsini küçüğe çevirir

            var result12 = sentence.ToUpper(); // hepsini büyüğe çeviri

            var result13 = sentence.Replace(" ", "-"); // boşluk yerine çizgi konur

            var result14 = sentence.Remove(2); //My yazar 2 den itibaren siler ya da 2,4 yazarak2 den sonra 4 tane siler

            Console.ReadLine();



        }
    }
}
