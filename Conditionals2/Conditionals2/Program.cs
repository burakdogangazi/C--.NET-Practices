using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }

            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }


            else
            {
                Console.WriteLine("Number is not 10");
            }

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");


            switch (number)
            {

                case 10:
                    Console.WriteLine("Number is 10");
                    break;

                case 20:
                    Console.WriteLine("nUMBER İS 20");
                    break;


                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }
            //Tek bir solution içine kurul yapılacaksa içine birden fazla proje konulur ve set as startapp project denir sol tıktan


            if(number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");

            }

            else if(number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }

            else if(number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");

            }



            if(number < 100)
            {
                if(number >= 90)
                {

                }

            }







        }
    }
}
