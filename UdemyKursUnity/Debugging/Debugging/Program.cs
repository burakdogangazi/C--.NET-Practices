using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {

            // bir kod satırının yanına tıkladıktan kırmızı mark bıraktıkdan sonra başlat ile o satıra kadar okur ve kodda üstüne gelince hangi değerlerde olduğunu görürüz
            // step over ile devam edebiliriz watch kısmından istediğimiz değişkeni yazarak takip edebiliriz yürütme penceresine değişkeni yazarsak değerini görürüz
            // yürütme penceresine ?i+3==99 yazarsak dcevabı false olarak görürüz
            int i = 3;
            i++;
            int x = 5;
            x++;
            int toplam = i + x;
            int toplam2 = 0;

            for(int y = 0; y < 1000; y++)
            {
                toplam2 += y;
                Console.WriteLine(y);
            }

            Console.WriteLine(toplam);
            
            Console.ReadLine();
        }
    }
}
