using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class Customer
    {
        protected int id { get; set; }// private sadece tanımlanan blokta kullanılır.
       
        // protected verilirse  ayn blokta kullanılır bütün classta
        // private olursa bu bloktakiler de save ve deletede gelir
        // private yaptın ve sonra başka sınıftan bunu ineritance ettin yine kullanamazsın
        // protected inheritance yaptığın sınıflarda kullanabilirsin

        public void Save()
        {
            
        }

        public void Delete()
        {
            
        }


    }

    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();
            
        }
    }
    // internal heryerden kullanılabilir başka sayfadan class ile bildirgeç kullanmadan kullanılır
    class Course// bir classın defaultu internaldır bir şey yazmıyorsa
    {
        public string Name { get; set; }
    }

    // Eğer farklı bir projeden de kullanabilmek istiyorsan public yapacaksın
    // İlk önce sağtık referenceden kullacağın projeyi seç 
    // kodlarına Using AccessModifiers ekle

   /* private class Course1 //Classlar protected ve private de olamaz
    {

    }*/
}
