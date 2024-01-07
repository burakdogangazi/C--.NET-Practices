using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add2(10, 20);

            //int number1 = 30;
            //int number2 = 100;
            //var result = Add3(out number1, number2);

            Console.WriteLine(Multiply(2, 4));

            Console.WriteLine(Add4(2, 3, 4, 5, 6, 1));

            Console.ReadLine();

        }
    
        static void Add()
        {
            Console.WriteLine("ADDED");
        }
       
        static int Add2(int number1, int number2 = 30)// YENİ ÖZELLİK PARAMETREYE DEĞER VERİYORSUN MAİNDEN YOLLAMAZSAN 30 OLARAK SAYILACAK
        {// DEFAULT DEĞER ATADĞIN İLK BAŞTA OLMAMALI
            return number1 + number2;
        }
        // ref anahtar kelimesi ile yollarsan sayı refereansdan gerçek değişir.
        // aynı koşulllar için out keyword ile de yapılabilir

        // ref ile out farkı --
        // ref ile yollarsan daha önceden değeri belirlemiş olman gerekir outta bunun önemi yok
        // ama out kullanıcaksan fonksiyondan return etmeden önce set etmen gerekir
        
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

       
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(params int[] numbers)// isteidğimiz kadar parametre yollayabilir son parametre olmalı default gibi
        {
            return numbers.Sum();
        }
        
        // her sayıyla toğladığında overload yapmamak için
        /*static int Add4(int number1, int number2, int number3)
        {
            return number1 + number2+  number3;
        }*/


    }
}
