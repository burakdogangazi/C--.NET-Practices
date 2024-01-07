using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();

            //Find();

            /* try
             {
                 Find();

             }
             catch(Exception exception)
             {
                 Console.WriteLine(exception.Message);
             }

             HandleException(() => // yukarıdakinin yerine
             { // Aciton void alır
                 Find(); // metod yerine kod göndericem
             });// boş metod göndericem karışılığı ise*/

            Console.WriteLine(Topla(2, 3));
            
            // 3. int çıktı output
            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3, 5));
            //aşağıdaki func bakınca parametresiz metodlara delege yapıyor çıktı olmalı tek int

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);

            };
            // değer döndüren ama değer istemeyen 
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            // yukarıdaki 2. kullanımı


            //Console.WriteLine(getRandomNumber());


        }
        
        static int Topla(int x,int y)
        {
            return x + y;
        }



        private static void HandleException(Action action) // bütün try catchleri yazarsın heryerden inherite edip ulaşırsın kod cathcler ile bulanmaz
        {// kısacası action ir metoda karşılık gellir kendi metodumu gönderiyorum çalıştırıyor
            try
            {
                action.Invoke(); // action aslında find metodu ve ınvoke ile try içinde çalıştır dedik
            }// bu sayede bir sürü catch bloğu yazmaktan kurtuluruz
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFound("Record Not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void NewMethod()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "SALİH" };
                students[3] = "Ahmet";

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
                // Console.WriteLine(exception.InnerException);// varsa daha detaylı bilgi
            }
        }

        private static void NewMethod1()
        {
            try
            {
                Find();

            }
            catch (RecordNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
