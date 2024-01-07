using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);

            Product product = new Product { id = 1, Name = "Laptop" };
            Product product1 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            
        }
    }

    class CustomerManager
    {
        private int _count = 15;   // private _ kullanılır yazım özelliği  
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()// eğer mainden içine değer gönderemezsen bunu dikkate alır
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0}", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void log();
    }

    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("lOGGED TO DATABASE");
        }
    }

    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("lOGGED TO file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(String entity)
        {
            _entity = entity;
        }
        
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager: BaseClass
    {
        public PersonManager(string entity):base(entity)// birinci değeri oraya yolladık 
        {

        }
    
        public void Add()
        {
            Console.WriteLine("added!");
            Message();
        }

    }

    static class Teacher
    {
        public static int Number { get; set; } // static eklemek zorunda class static
    }                                           // ayrıca static newlenemez 

    static class Utilities // static sınıfta her şey statik olmalı
    {
        static Utilities()// constructor static
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        
        
            public static void DoSomething()
        {
            Console.WriteLine("Done");
        }


        public void DoSomething2()
        {
            Console.WriteLine("Done2");
            Utilities.Validate(); // statik olmayan bloktan static çağırabiliyorsun

        }


    }

}
