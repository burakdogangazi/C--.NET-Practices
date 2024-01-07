using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    { // Nesneler arası hiyerarşi ve o nesenelere istediğmiz zaman ulaşabilmek
        // kurumlardaki roller ve hiyerarşi sıklıkla kullanılır.
        static void Main(string[] args)
        {

            Employee burak = new Employee { Name = "Burak Doğan" };

            Employee metin = new Employee { Name = "Metin Doğan" };

            burak.AddSubordinate(metin);

            Employee aziz = new Employee { Name = "Aziz Doğan" };

            metin.AddSubordinate(aziz);

            Employee yeliz = new Employee { Name = "Yeliz Doğan" };

            aziz.AddSubordinate(yeliz);

            Contractor yusuf = new Employee { Name = "Yusuf Doğan" };

            yeliz.AddSubordinate(yusuf);


            Console.WriteLine(burak.Name);
            foreach (Employee manager in burak)
            {
                Console.WriteLine("  {0}",manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("  {0}",employee.Name);
                }
            }

            Console.ReadLine();









        }
    }

    interface IPerson
    {
        string Name { get; set; }

    }

    class Contractor : IPerson
    {
        public string Name { get; set; }

        public static implicit operator Contractor(Employee v)
        {
            throw new NotImplementedException();
        }
    }

    class Employee : IPerson,IEnumerable<IPerson> // enumerable foreach ile gezinebilir
    {
        List<IPerson> _subordinates = new List<IPerson>();
        
        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }


        public IPerson GetSubordinate (int index)
        {
            return _subordinates[index];
        }





        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
