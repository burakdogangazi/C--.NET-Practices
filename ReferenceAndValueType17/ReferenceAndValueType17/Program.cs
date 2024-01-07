using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType17
{
    class Program
    {
        static void Main(string[] args)
        {

            //Değer tipidir referans yoktur.
            int number1 = 10;
            int number2 = 20;

            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);


            //Arrayler Referans tipidir
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);//istanbul
            Console.WriteLine(cities2[1]);//adana 
            //artık cities2 cities1 gösteriyor cities2 nin önemi yok garbage collector temizleyecektir. cities2 değerlerini


            



            Console.ReadLine();

        }

    }
}
