using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalAbstracting14
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }

    //Interface kullandık çünkü metodlar hepsinde aynı isim ama farklı kod satırları içerirken
    // ama bazı metodlar aynı bazı metodlar farklı olsalardı abstract kullanıp aynı metodu direk yuarkıdan alıp yeni metodları virtualdaki gibi override edebilirdik.

    class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added");
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To File");
        }
    }


}
