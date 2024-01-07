using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;// değer
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            // string referans ile çalışır
            string[] cities = new string[] { "ANKARA", "ADANA", "AFYON" };// referans
            string[] cities2 = new string[] { "Bursa", "Bolu,", "Balıkesir" };
            cities2 = cities;

            cities[0] = "İstanbul";//ankara , istanbul olur

            //DataTable dataTable = new DataTable();
            //DataTable dataTable2 = new DataTable();
            //dataTable2 = dataTable; // referans ile bağlandı ilki garbage collector ile toplandı sistem kötü kullanıldı


            DataTable dataTable; // new bellek harcar yapmadan böyle yapılabilir
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;



        }
    }
}
