using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops5
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //For Döngüsü
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");

            //While Döngüsü

            int number = 100;
            while(number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine(" Now Number is {0}", number); // -1 olur 


            //Do - While Loop
            int number2 = 10; // olmasa bile bir kez çalışır
            do
            {
                Console.WriteLine(number2);
                number--;
            }

            while (number >= 0);


            //ForeEach
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach(var student in students)
            {
                Console.WriteLine(student); // döngü içinde eleman değiştiremiyoruz
            }



            
            Console.ReadLine();


        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i = 2; i < number-1; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                }
            }

            return result;



        }

    }
}
