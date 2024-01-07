using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors16
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            
            Product product = new Product { Id = 1, ProductName = "Laptop" };
            //getter setter property ile tanım
            
            Product product1 = new Product(2, "Computer");
            //ctor ile tanım


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLoggerr());

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            manager.DoSometing2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {

        private int _count = 15;//private field alt çizgili yapılır.

        public CustomerManager(int count)
        {
            _count = count;
        }
        // eğer mainden newsne oluştururken birşey yollmazasak boş olan ctor çalışır
        //ctor overloading
        public CustomerManager()
        {

        }


        public void List()
        {
            Console.WriteLine("Listed {0}",_count);
        }

        public void Add()
        {
            Console.WriteLine("ADDED");
        }


    }

    class Product
    {

        public Product()
        {

        }

        private int _id;
        private string _productname;

        public Product(int id,string productname)
        {
            _id = id;
            _productname = productname;
        }


        public int Id { get; set; }
        public string ProductName { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLoggerr : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }

    }


    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
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
            _logger.Log();
            Console.WriteLine("Add");
        }
    }



    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;

        }

        public void Message(string entity)
        {
            Console.WriteLine("{0} MESSAGE", entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message("Merhaba");
        }

    
        

    }


    static class Teacher // staticler newlenemez
        //static sınıfın elemanları da statik
        //statik ortaktır biri değişirse hepsi değişir bellekte üretilir
    {

        public static int Number { get; set; }


    }

    static class Utilities
    {
        static Utilities()
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

        public void DoSometing2()
        {
            Console.WriteLine("Done2");
        }


    }













}
