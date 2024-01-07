using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    class Program
    { // kod testi yapıyoruz ama loglama yapmasın istiyoruz gerek yok çünkü kontorl amaçlı yapıyoruz.
        // o zaman null bir nesne göndermemiz lazım ama null hata verir loglama için hiç bir şey yapmayan sınıfı enjecte edicez
        // Hiç bir şey yapmayan nesen hem performans arttırılması hem de sahtenin bir nesnesi gönderilmesi olur.
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());

            customerManager.Save();




        }
    }

    class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
            _logger.Log();
        }

    }


    interface ILogger
    {
        void Log();
    }

    class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with log4net");
        }
    }

    class NlogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with nloglogger");
        }
    }

    class StubLogger : ILogger
    {
        //singleton thread safe
        private static StubLogger _stubLogger;
        private static object _lock = new object();

        private StubLogger(){}

        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if(_stubLogger == null)
                {
                    _stubLogger = new StubLogger();
                }

                return _stubLogger;
            }
        }


        public void Log()
        {
           
        }
    }

    class CustomerManagerTests
    {
        public void SaveTest()
        {
            //CustomerManager customerManager = new CustomerManager(new Log4NetLogger()); //test kodu içine log sistemi istiyor
            // ancak biz sadece iş kodu çalışıyor mu diye bakıcaz loglama istemiyoruz test için
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger()); // null veremiyoruz hata verir.
            // newlemedik maliyet düştü
            customerManager.Save();
        }
    }

}
