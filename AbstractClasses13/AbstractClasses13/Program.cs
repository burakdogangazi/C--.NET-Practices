using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database database = new Database(); newlenemez interface gibi

            Database sqldatabase = new SqlServer();
            sqldatabase.Add();
            sqldatabase.Delete();

            Database oracledatabase = new Oracle();
            oracledatabase.Delete();
            oracledatabase.Add();

        }
    }
    // interface de metod içini yazamazdık inherite edilenler aynısını yazmak zorundayken
    // burada class interface mantığının birleşimi metodu hem yazıyoruz hem de imza şeklinde bırakabiliyoruz.
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by def");
        }
        // interface de sadece property ya da metod ismi olabilir burada içeriğini de belirleyebiliyoruz çünkü sınıftır ayrıca
        public abstract void Delete(); // içi boş olan virtual metoddur sadece alır herkes kendi yazar
    }


    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("DELETED BY ORACLE");
        }
    }
}
