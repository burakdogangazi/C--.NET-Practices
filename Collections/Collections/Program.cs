using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();

            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // anahtar ve hangi değer
            dictionary.Add("book", "Kitap");
            dictionary.Add("table", "masa");
            dictionary.Add("computer", "Bilgisayar");
            Console.WriteLine(dictionary["table"]);

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine(item);
            };

            //dictionary.ContainsKey("glass");// false döndürür contains value de var

        }

        private static void NewMethod1()
        {
            /*string[] cities = new string[2] { "Ankara", "istanbul" };
                        cities = new string[3];// yeni referans aldık içi boş oldu ankara istanbul ulaşamadık
                        Console.WriteLine(cities[0]);*/

            

            List<string> cities = new List<string>();
            cities.Add("ankara");
            //cities.Add(1);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            // List < Customer > customers = new List<Customer>();

            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Burak" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Engin" },
                new Customer { Id = 2, FirstName = "Burak" }

            };
            var count = customers.Count;//2
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };

            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Ali"},
                new Customer {Id = 5, FirstName = "Ayşe"}
            });

            //customers.Clear();

            //customers.Contains(new Customer {Id = 1, FirstName = "Engin"})// arama yapar içerir mi varsa true döner
            // yukarısı false verir yenilendi farklı ref oluşturulduğu için

            var index = customers.IndexOf(customer2);


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var lastindex = customers.LastIndexOf(customer2);

            customers.Insert(0, customer2);// kaydırır

            customers.Remove(customer2);// bulduğu ilk customer2 yi çıkarır aynı elemandan 3 tane varsa 1. yi çıkarır

            customers.RemoveAll(c => c.FirstName == "Salih");// salihleri çıkar
        }

        private static void NewMethod()
        {
            ArrayList citiesList = new ArrayList();

            citiesList.Add("Ankara");
            citiesList.Add('A');
            citiesList.Add("İstanbul");
            citiesList.Add(1);
            foreach (var city in citiesList)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }



}
