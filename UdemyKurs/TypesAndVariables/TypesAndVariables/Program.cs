using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipleri
{
    class Program
    {

        enum Days
        {
            Monday,Tuesday,Wednesday,Friday
                // 0 1 2 3 diye değerleri vardır eğer monday = 10 yaparsan diğerleri 11 12 diye gider.

        }
        static void Main(string[] args)
        {


            int number1 = 10; //4 byte

            Console.WriteLine("Number 1 is {0}", number1);

            
            long number2 = 1312312313;// 8 byte

            Console.WriteLine("Number 2 is {0}", number2);


            
            short number3 = 32767; //2 byte

            Console.WriteLine("Number 3 is {0}", number3);


            byte number4 = 255; // 1byte

            Console.WriteLine("Number 4 is {0}", number4);


            bool condition = false;


            char character = 'A';

            Console.WriteLine("Character 1 is {0}", (int)character);

            double number5 = 10.4;


            decimal number6 = 10.4m;

            
            decimal number7 = 10;

            string days = "Monday";


            //if(Days.Friday == xx )

            var number8 = 10;// ilk tanımlı int olduğu için int sayılır başka aatarsan int sayar.

            number8 = 'A'// 65 değerini verir
        }
    }
}
