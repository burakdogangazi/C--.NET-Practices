using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {// Bir nesnein ve örnek değerinin değiştiği zaman aynı şekilde kullanılması
        //Web sitesi anlık ziyaretçi sayısı bütün kullanıcılarda aynıdır nesnenin durmunun kontrol edilmesi
        //Bir nesne örneği sadece işlem yapıyorsa değer tutmuyorsa bu design pattern kullanılır productmanager da değer tutan yok işlem tutan var add delete
        // update get all gibi her newlendiğined bir daha oluşur ve pahalıdır nesne bir kez üretilip her yerde kullanılmalıdır
        // bu design ile nesne oluşturdun nesne direk oluşur ve kapanmaz program kapatılmadıkça
        // nadir kullanılan nesne singleton ile kullanılması gereksizdir.
        // değer tutmayan işlem yapan sık çağırılan nesnelerde kullanılır
        //Nesne aynı anda iki farklı taraftan üretilirse aynı nesneden 2 tane olur thread safe singleton
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager(); hata verir

            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();


        }
    }

    class CustomerManager
    {   //1 Dıştan direk erişime kapamak için const oluştur.
        //2 static kendini döndüren metod
        //3 Field oluştur ve if yaz

        static CustomerManager _customerManager;
        static object _lockObject = new object(); // eğer oluşturulmaışsa nesne daha objeyi kilitler
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if(_customerManager == null)
                {
                    _customerManager = new CustomerManager();
                }
            }

            return _customerManager;
        }


        public void Save()
        {
            Console.WriteLine("Saved.");
        }

    }

}
