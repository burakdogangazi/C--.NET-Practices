using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers15
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Customer
    {
        private int Id { get; set; } // başka sınıftan kullanamayız ama globalde belirledik bu sınıf içşnde istediğimiz yerden kullanabiliriz
        protected string LastName { get; set; }
        //protected yaparsak

        int id;// default yanına belirtmediğin için rpivate değişkendir.



        public void Save()
        {
            // id buraya yazmış olsaydık başka fonksiyondan erişemezdik
            //private değişken buraya özel olurdu
        }
    }

    class Student:Customer // inherite etsen bile Id erişemeyiz sadece olduğu classa özeldir
    {                      // protected tanımladığımız metod inherite edildiği zaman kullanılabilir private da o da olmaz
        public void Save()
        {
            Customer customer = new Customer();
            
        }
    }

    class Course // class ın defaultu internaldır
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }

    }
    /*
     
     Private - protected - internal
     1. Private sadece sınıfa özel inherite edilse bile başka yerde kullanılamaz.
     2. Protected private aynısı + sı ise inherite edilince de kullanılabilmesi
     3. Internal bütün projede geçerli obje üretilerek kullanılabiliyor.
     4.private classlar inner class şeklinde kullanılabilir.
     5. Public de add reference ekleyip başka projedeki sınıfı referans ile ekleyip using AccessModifers kullanmalıyız
     */



}
