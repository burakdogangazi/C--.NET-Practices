using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {

            //string student1 = "Engin";
            //string student2 = "Burak";
            //string student3 = "Doğan";

            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Burak";
            students[2] = "Doğan";

            string[] students2 = { "Engin", "Burak", "Doğan" };

            string[] students3 = new string[3]{ "Engin", "Burak", "Doğan" };


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 3]{

                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"x","y","z"},
                {"a","b","c"},
                {"d","e","f"},
                {"k","n","m"},
                {"q","w","p"},

            }; // 7 satır 3 sütun

            // Satırlar 0. dimension sütunlar 1. dimension
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**************************");
            }



            Console.ReadLine();

        }
    }
}
