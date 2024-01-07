using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions19
{
    class Program
    {
        static void Main(string[] args)
        {

            //Action da o bloktaki her şeyi çalıştır derken
            // func ta çalıştır  ve bana bir değer döndür diyebiliyoruz.


            //1.kısım
            Func<int, int, int> add = Topla;

            Console.WriteLine(add(3, 5));

            //giriş giriş çıkış




            //2.Kısım
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            // sadece bir int var demek ki bu bir int döndürüyor ama parametresiz void metodda
            Console.WriteLine(getRandomNumber());


            

            //3.Kısım
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());



            Console.ReadLine();

        }


        static int Topla(int x, int y)
        {
            return x + y;
        }


        private void FirstPart()
        {

            try
            {

                string[] students = new string[3] { "Burak", "Doğan", "Salih" };

                students[3] = "Doğan2"; //hata verir


            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.InnerException); // daha fazla bilgi
                throw;
            }

        }
        private void ThirdPart()
        {


            //3.KISIM 2.kısımdaki gibi uzun yazmak yerine action delegasyonu kullandık

            HandleException(() =>
            {

                Find();
            });




        }
        private void SecondPart()
        {
            //2.Kısım

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
        private static void HandleException(Action action) // action kod bloğu içindeki yazıyı temsil eder bizde sadece find yazıyor.
        {
            try
            {
                action.Invoke();// METOD İÇİNE YOLLADIĞIMIZ ACTIONU BURADA ÇALIŞTIR DEMİŞ OLDUK.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }



        }

        private static void Find()
        {

            List<string> students = new List<string> { "Burak", "Doğan", "Metin" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }

            else
            {
                Console.WriteLine("Record Found!");
            }

        }

    }

    class RecordNotFoundException:Exception
    {

        public RecordNotFoundException(string message)
        {

        }

    }
}
