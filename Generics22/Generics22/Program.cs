using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics22
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer(), new Customer());

            foreach (var customer in result2)
            {
                //Console.WriteLine(customer.FirstName);

            }
        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }


        class Product
        {

        }

        interface IProductDal:IRepository<Product>
        {
            //List<Product> GetAll();
            
            //Product Get(int id);

            //void Add(Product product);

            //void Delete(Product product);

            //void Update(Product product); 


        }

        class Customer
        {

        }

        interface ICustomerDal:IRepository<Customer>
        {
            //List<Customer> GetAll();

            //Customer Get(int id);

            //void Add(Customer customer);

            //vSoid Delete(Customer customer);

            //void Update(Customer customer);


        }

        interface IRepository<T> where T:class ,IEntity,new() // buraya referans tip yazılabilir demek kıstas koymuşolduk saece referans tipi
            // referans tipi olmalı ve new() lenebilmeli artık string de kullanılamaz
        {   //IEntity den implemente olmalı 
            // new sonda olmalı
            // sadece değer tipleri koymak istersek struct yazardık
            List<T> GetAll();

            T Get(int id);

            void Add(T entity);

            void Delete(T entity);

            void Update(T entity);
        }

        interface IStudentDal : IRepository<string>
        {

        }

        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }

        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}
