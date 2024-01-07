using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {

        private static bool AsalMi(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                }
            }
            return result;
        }



            static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }

            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                
                number--;
            }


            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >=0);


            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            foreach(var student in students)
            {
                //student = "Ahmt"; hata verir
                Console.WriteLine(student);
            }



        }




    }
}
