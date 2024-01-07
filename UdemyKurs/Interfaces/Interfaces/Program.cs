using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager manager = new PersonManager();
            //manager.Add(new Customer {Id =1, FirstName ="Burak" , LastName = "Dogan", Address = "Aydın"});

            //Student student = new Student
            //{
            //    Id = 1,
            //    FirstName = "Dogan",
            //    LastName = "Burak",
            //    Department = "Comp.sci"
            //};
            //manager.Add(student);


            //IPerson PERSON = new IPerson(); // İNTERFACE NEW edilemez ama
            // IPerson person = new Customer(); yapılabilir
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.add(new SqlServerCusotmerDal());

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCusotmerDal(),
                new OracleCusotmerDal
            };

            foreach( var customerDal in customerDals)
            {
                customerDal.add();
            }

        }
 
    }

    interface IPerson// soyut
    {
         int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    // ımpelement etmek zorunda altclasslar
    class Customer : IPerson//somut
    {
        public int Id { get ; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set  ; }

        public string Address { get; set; }
    }

    class Student: IPerson//somut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)// customer yazdık istedik mainden verdik ama student veremedik
                                                // ıPerson yazsaydık her class ckullanabilir onu implement eden
        {
            Console.WriteLine(person.FirstName);
        }
    }


}
