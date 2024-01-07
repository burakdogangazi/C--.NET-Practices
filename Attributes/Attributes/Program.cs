using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes// öznitelikler
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Engin", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    [ToTable("Customers")] // customers tablosuna denk gelir
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]// girmesi zorunlu yapıyoruz ilgili nesne için kural 
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
        [RequiredProperty]


    } 

    [AttributeUsage(AttributeTargets.Property ,AllowMultiple =true)]// birden fazla kullanıma aç kapa true false ile
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]//SADECE PROPERTY EKLENEBİLİR
    class RequiredPropertyAttribute : Attribute
    {
    }

    class CustomerDal
    {
        [Obsolete("dont use")]// eski bunu kullanma anlamı taşır yenisi var
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}{1}{2}{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        
        }


        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}{1}{2}{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);

        }

    }


    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }



}
