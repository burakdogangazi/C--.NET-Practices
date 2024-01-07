using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();// buradan değiştirerek logger yerini seçiyoruz
            customerManager.Add();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        
        public void Add()
        {

            Logger.log();
            Console.WriteLine("Customer Added!");

        }

    }

    class DatabaseLogger :ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger: ILogger
    {

        public void log()
        {
            Console.WriteLine("Logged to file");

        }
    }

    interface ILogger
    {
        void log();

    }

}
