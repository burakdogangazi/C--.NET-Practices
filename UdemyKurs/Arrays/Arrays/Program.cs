using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Burak";
            string student2 = "Derin";
            string student3 = "Metin";

            string[] students = new string[3]{"Ahmet","Mehmet","Serin" };

            /*students[0] = "Ahmet";
            students[1] = "Mehmet";
            students[2] = "Serin";*/

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = {"Ahmet", "Mehmet", "Kerim"};
            // students2[3] = "Kemal"; hata verir indexoutofrangeexception


            string[,] regions = new string[7, 3] 
            {
                {"","",""},
                {"","",""},
                {"","",""},
                {"","",""},
                {"","",""},
                {"","",""},
                {"","",""},

            };
            // satırlar 0. dimension sütunlar 1. dimension
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1) ; j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }
            
            
            
            
            // regions[0, 0] = "İstanbul";



        }
    }
}
