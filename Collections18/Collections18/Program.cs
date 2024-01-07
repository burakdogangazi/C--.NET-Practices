using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections18
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities[2] = "Adana"; hata vericek eleman ekleyemedik.

            ArrayList cities2 = new ArrayList();
            cities2.Add("Ankara");
            cities2.Add("İstanbul");
            
            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }

            cities2.Add("Bursa");
            cities2.Add(1);
            //Düz bir arraylistte her değeri kullanarak array oluşturulabilirken tip güvenli farklıdır.


            //Tip Güvenli

            List<string> cities3 = new List<string>();

            cities3.Add("Ankara");
            //cities3.Add(1); 1 veremeyeiz sadece string

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Burak" });
            customers.Add(new Customer { Id = 2, FirstName = "Doğan" });

            foreach(var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count; //2

            var customer2 = new Customer
            {
                Id =1,
                FirstName = "Metin"
            };

            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 5, FirstName = "Ali"},
                new Customer { Id = 6,FirstName = "Ayşe"}
            });

            //customers.Clear();

            //cities.Contains("Ankara"); // true döner

            customers.Contains(customer2);

            //customers.IndexOf(customer2);// customer 2 kaçıncı sırada?

            //customers.LastIndexOf(customer2); // sondan başlar aramaya

            customers.Insert(0,customer2); //istenilen yere koyar ordakileri kaydırır silmez

            customers.Remove(customer2); // bulduğu ilk değeri siler hepsini silmez 

            customers.RemoveAll(c => c.FirstName == "Salih"); //bütün salihleri direk siler

            //Sözlük yapısı

            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("book", "kitap");
            dict.Add("table", "masa");

            var deger = dict["table"];//masa verir

            dict.ContainsKey("glass");//false

            dict.ContainsValue("kitap"); //true

        }


    }


    class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
    }

}
