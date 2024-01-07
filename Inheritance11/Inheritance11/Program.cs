using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance11
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //customer.City

            Person[] persons = new Person[3]
            {
                new Customer { FirstName = "Burak" },
                new Student { FirstName = "Doğan" },
                new Person { FirstName = "Metin" },

            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }

        }

        class Customer : Person
        {
            public string City { get; set; }
        }


        class Person2
        {
            // Bir sınıfın tek bir yerden inheritance yapılabilir interfacede birden çok
            //Bir çocuğun bir babası olabileceği gibi
            //Hem Inheritance Hem Interface impelemente ediceksek ilk önce inheritance sonra interface yazılır 
        }

        class Student : Person
        {
            public string Department { get; set; }
        }

    }
}
