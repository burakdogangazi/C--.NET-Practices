using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //string city = "Ankara";
            //Console.WriteLine(city[0]);
            //Console.ReadLine();

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            //string city2 = "İstanbul";

            //string result = city + city2;
            //Console.WriteLine(String.Format("{0} {1}", city, city2);
            //Console.WriteLine(result);


            string sentence = "Burak Doğan";
            var result = sentence.Length;
            Console.WriteLine(result);

            var result2 = sentence.Clone();// daha sonradan değiştirirsen sentenceyi değişmez clone 

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("b");
            var result5 = sentence.IndexOf("n");// name yazdın  ilk başladığı yerini indeksini döndürür bulamazsa -1
            var result6 = sentence.IndexOf(" ");// bulduğu ilk boşluğu
            var result7 = sentence.LastIndexOf(" ");// sondan aramaya başlar
            var result8 = sentence.Insert(0, "Hello ,");
            var result9 = sentence.Substring(3); // name is Derin Demiroğ
            var result10 = sentence.Substring(3,4); //3.karakterden sonra 4 tane al
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ","-");
            var result14 = sentence.Remove(2);// My (2,5) 2den sonra  karakteri sil
        }
    }
}
