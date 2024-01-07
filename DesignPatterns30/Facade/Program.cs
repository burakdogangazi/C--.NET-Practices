using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    { // Sadeleştirme için aracı sınıf oluşturmak.
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
            Console.ReadLine();

        }
    }

    class Logging: ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching: ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User Checked");
        }
    }

    class Validation : IValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    internal interface IValidate
    {
        void Validate();
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }

    class CustomerManager
    {

        private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }
        
        public void Save()
        {
            _concerns.Caching.Cache();
            _concerns.Authorize.CheckUser();
            _concerns.Logging.Log();
            _concerns.Validate.Validate();

        }

    }

    class CrossCuttingConcernsFacade
    {
        public ILogging Logging;
        public ICaching Caching;
        public IAuthorize Authorize;
        public IValidate Validate;

        public CrossCuttingConcernsFacade()
        {
            Logging = new Logging();
            Caching = new Caching();
            Authorize = new Authorize();
            Validate = new Validation();
        }
    }


}
