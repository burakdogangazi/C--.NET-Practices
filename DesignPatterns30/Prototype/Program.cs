using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    { // Amaç nesen üretim maliyetlerini minimize etmektir.
        //Prototip temel nesne ya da kişidir.
        //Clone layarak newleme maliyetlerini en aza düşürdük



        static void Main(string[] args)
        {

            Customer customer = new Customer
            {
                FirstName = "Burak",
                LastName = "Doğan",
                City = "Ankara",
                Id = 1
            };

            

            Customer customer2 = (Customer)customer.Clone();

            customer2.FirstName = "Metin";

            

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
            //Ayrı nesneler farklı isimler oluşur.
            //customer ve customer 2 aynı referansta değiller ama newlemeden
            //maliyetten kaçırarak oluşturduk


            Console.ReadLine();

        }
    }

    public abstract class Person
    {

        public abstract Person Clone();

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }


    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }


    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }












}
