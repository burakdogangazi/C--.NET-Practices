using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes7
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.ReadLine();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Burak";
            customer.LastName = "Doğan";


            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Doğan",
                LastName = "Burak"
            };

            Console.WriteLine(customer2.FirstName);



        }
    }


    


    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");

        }

        public void Update()
        {
            Console.WriteLine("Product updated!");
        }

    }

}
