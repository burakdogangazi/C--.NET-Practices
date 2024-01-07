using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[10]// boyut söylemek zorundasın;

            sayilar[0] = 45;
            sayilar[1] = 30;
            //sayilar[10] son indeks 9 olur 10 elemanlı 0 dan başladığı için

            //string[] isimler = new string[3];
            string[] isimler = { "Ayşe", "Ahmet", "Mehmet" };
            Console.WriteLine(isimler.Length);
        
        }
    }
}
