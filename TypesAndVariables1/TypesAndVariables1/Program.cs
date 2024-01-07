using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables1
{
    class Program
    {
        static void Main(string[] args)
        {
            // .net FrameWork
            Console.WriteLine("İlk program");
            Console.ReadLine();

            /* Yorum Satırı*/

            //VeriTipleri

            int number1 = 10; // 4 byte
            Console.WriteLine("Number1 is {0}", number1);

            long number2 = 2147483648; // 8 byte
            Console.WriteLine("Number2 is {0}", number2);

            short number3 = -32678; //2byte
            Console.WriteLine("Number3 is {0}", number3);

            byte number4 = 255; // 1byte
            Console.WriteLine("Number4 is {0}", number4);

            bool variable = true; //1byte
            Console.WriteLine("Variable is {0}", variable);

            char character = 'A'; // 1byte
            Console.WriteLine("Cha is {0}", (int)character); // 65 ascii basar

            double number5 = 10.2532; // 8 byte
            Console.WriteLine("Number1 is {0}", number5);

            decimal money = 10.4m; // 16 byte
            Console.WriteLine("Decimal is {0}", money);

            //if (Days.Monday = "Monday")
            //{

            //}
            Console.WriteLine((int)Days.Monday); // 10 olur 10 olur başlangıç değeri verdiğimiz için olmasaydı 1 olurdu

            var number7 = 10;
            number7 = 'A'; // 65 
            Console.WriteLine(number7); // 65 basar çünkü ilk atama integer olduğu için sonrakiler hep int yapar ama stringi çeviremeyiz
        
        }
    }

    enum Days
    {
        Monday = 10,Tuesday,Wednesday,Thursday
    }
}
