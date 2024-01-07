using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();

            int x = Add(10,20);

            int b = Add(2); // a nın yerine koyar boş olduğu için

            int number1 = 20;

            int number2 = 100;

            var result2 = Add2(ref number1, number2);

            Console.WriteLine(number2);

            Console.WriteLine(Multiply(2, 4));

            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add3(1, 2, 3, 4, 5, 6, 7));


            Console.ReadLine();
        }

        static int Add(int a,int b = 30) // main static olduğu için staticten static metod çağırılmalıdır
        { // b verilmezse default olarak 30 kullanılır.
            return a + b;
        }

        static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        static int Add2(ref int number1, int number2)
        {
            number1 = 30; // burda değiştirdik 30 dolu artık mainde de
            return number1 + number2;

            // ref ile out farkı - referans modeli

            //1 Ref te metoda gönderilmeden önce değerin belirlenmesi lazım ve her iki tarafa hem metoda hem main içinde ref keywordü başa yazmak gerekiyor.

            //2 Out ile ref aynı mantıktadır sadece değer belirlenmeden int number1 şeklinde gönderilebilir ancak metodda kullanılırken return öncesi değerin belirlenmesi gerekir

        }


        //Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }



        //Params Keywordu
        static int Add3(int number1,params int[] numbers) // params sonda olmak zorunda
        {
            return numbers.Sum();
        }

        

    }
}
