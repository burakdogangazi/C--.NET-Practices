using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {//En sık kullanılan patternlerdendir ve değişiklikleri korumak gelişitrilmeye açık olunması için teknoloji değişikliği.
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();

            Console.ReadLine();

        }
    }

    public class LoggerFactory:ILoggerFactory
    {

        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new BDLogger();
        }


    }

    public class LoggerFactory2 : ILoggerFactory
    {

        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new MDLogger();
        }


    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }


    public interface ILogger
    {
        void Log();
    }


    public class BDLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with BDLogger");
        }
    }

    public class MDLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with MDLogger");
        }
    }

    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;
        

        public CustomerManager(LoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();

        }
    }

}
