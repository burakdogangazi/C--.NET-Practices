using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes23
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 1, LastName = "Burak", FirstName = "Doğan", Age = 10 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }

        [ToTable("Customers")]
        class Customer
        {

            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; }
            [RequiredProperty]
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }

        }

        class CustomerDal
        {
            [Obsolete("Dont use add instead addNew")]// hazır attribute kullanma
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }


        }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] // bütün yerlere kullanılabilir .class der isek sadece class larda kullanılabilir .propert
        class RequiredPropertyAttribute:Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)] // birden fazla kullanabilirmiyiz tek class a 
        class ToTableAttribute : Attribute
        {

            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;

            }

        }





    }
}
