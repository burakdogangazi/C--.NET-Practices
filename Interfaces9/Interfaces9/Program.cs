using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces9
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Doğan",
                Adress = "Ankara"
            
            };


            Student student = new Student()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Doğan",
                Department = "Ankara"
            };

            personManager.Add(student);

            //2.Kısım

            //interface newlenemez ama

            IPerson person = new Customer(); // yapılabilir

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new SqlServerCustomerDal());


            /*
             KISA ÖZET OLARAK AYNI ALT KÜMEDEYER ALAN YA DA FARKLI VERİTABANLARI
             OLMASINA RAĞMEN HER İKİSİNDE DE AYNI İŞLEMLERİ BULUNDURAN UPDATE DELETE GİBİ İŞLEMLERİ
             O SINIFA UYGULATMAK İÇİN İNTERFACE KULLANIYORUZ VE INTERFACELER NEWLENEMİYOR
             
             */


            //3.KISIM Array Olarak Kullanmak

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                 new SqlServerCustomerDal(),
                 new OracleCustomerDal(),
                 new MySqlCustomerDal()
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }



        }

        interface IPerson // Soyut Nesne class somut nesne
        {
            int Id { get; set; }
            string FirstName { get; set; }

            string LastName { get; set; }

            //İnterfaceleri inherite eden sınıflar imzaları kullanmak zorundadır.
        }


        class Customer : IPerson
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Adress { get; set; }
        }

        class Student : IPerson
        {

            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Department { get; set; }
        }


        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName); // Iperson sayesinde onu inherite eden bütün classlardan nesne gönderebiliriz.

            }
        }

    }
}
