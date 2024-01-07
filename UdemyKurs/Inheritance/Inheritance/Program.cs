using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Person[] persons = new Person[3]
            {
                new Customer{FirstName = "Burak" },new Student{ FirstName = "Dogan"}, new Person{FirstName = "Metin"}
            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }

    class Person2
    {

    }
    class Person
    {
        public int  Id { get; set;}
        public string FirstName { get; set;}
        public  string LastName { get; set; }
    }

    class Customer: Person//,Person2 bir nesneyi bir kere inheritance yapılabilir
    {
        public string City { get; set; }
    }

    class Student: Person
    {
        public string Department { get; set; }
    }


}
