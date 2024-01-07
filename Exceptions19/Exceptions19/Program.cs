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

            try
            {

                string[] students = new string[3] { "Burak", "Doğan", "Salih" };

                students[3] = "Doğan2"; //hata verir


            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.InnerException); // daha fazla bilgi
                throw;
            }


            //2.Kısım

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }


            //3.KISIM 2.kısımdaki gibi uzun yazmak yerine action delegasyonu kullandık

            HandleException(() =>
            {

                Find();
            });














        }

        private static void HandleException(Action action) // action kod bloğu içindeki yazıyı temsil eder bizde sadece find yazıyor.
        {
            try
            {
                action.Invoke();// METOD İÇİNE YOLLADIĞIMIZ ACTIONU BURADA ÇALIŞTIR DEMİŞ OLDUK.
            }
            catch(Exception exception)
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
}
