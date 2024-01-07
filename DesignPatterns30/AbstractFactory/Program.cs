using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    { // toplu nesne kullanımında nesne kullanımını kolaylaştırmak ve mantığa göre nesne oluşturulması
       // kimlere mail gidecek kimlere gitmeyecek gibi kullanım
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
            Console.ReadLine();
        }
    }

    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with Log4net");
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("NLogger ");
        }
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with MemCaching");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with RedisCaching");
        }
    }

    public abstract class CrosssCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();

    }

    public class Factory1 : CrosssCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new Log4NetLogger();
        }

        public override Logging CreateLogger()
        {
            return new RedisCache();
        }
    }

    public class Factory2 : CrosssCuttingConcernsFactory
    {
        public override Caching CreateCaching()
        {
            return new NLogger();
        }

        public override Logging CreateLogger()
        {
            return new MemCache();
        }
    }

    public class ProductManager
    {
        CrosssCuttingConcernsFactory _crosssCuttingConcernsFactory;

        private Logging _logging;
        private Caching _caching;


        public ProductManager(CrosssCuttingConcernsFactory crosssCuttingConcernsFactory)
        {
            _crosssCuttingConcernsFactory = crosssCuttingConcernsFactory;
            _logging = _crosssCuttingConcernsFactory.CreateLogger();
            _caching = _crosssCuttingConcernsFactory.CreateCaching();
        }
        public void GetAll()
        {
            _logging.Log("lOGGED");
            _caching.Cache("CACHED");
            Console.WriteLine("Products Listed");
        }

    }





}
