using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Utilities utuilities = new Utilities();
            List<string> result = utuilities.BuildList<string>("Ankara", "İzmir", "Adana");

            List<Customer> result2 = utuilities.BuildList<Customer>(new Customer { FirstName = "Burak"});

        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    interface IProductDal: IRepository<Product>
    {
        
    }
    class Product : IEntity
    {


    }

    class Customer: IEntity// veri tabanı nesnesidir
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal:IRepository<Customer>
    {
        
    }
    interface IStudentDal:IRepository<Student>
    {

    }

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }
                                                // referans tiplip new yapılabilmeli ve Ientity implemente etmeli
    interface IRepository<T> where T:class, IEntity, new() // burdaki yazılan şey class olabilir değil referans tip demektir string olablir msela new yazarsak buraya yazılan referans tip olmalı newlenebilmeli ayrıca bu sefer string olmaz
    {                                           // saadece değer tipi istiyorsun struct yapıyorun
        List<T> GetAll();
        T Get(int id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }

    class ProductDal : IProductDal // Niye repository yazmadık çünkü Iproductdala özel bir şey yazarsan implemente ister sadece bunda eğer repostriy yazarsan customerdalda sadece yapmak istediğin işlemi ikisine imlpelemnte yapmak zorunda olursun
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
