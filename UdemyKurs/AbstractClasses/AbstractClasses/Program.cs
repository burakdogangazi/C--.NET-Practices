using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new Oracle();
            database2.Add();
            database2.Delete();
        }
    }

    abstract class Database
    {
        public void Add()// ekleme her yerde aynı
        {
            Console.WriteLine("added by default");

        }

        public abstract void Delete();// silme her yerde farklı

    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("deleted by oracle");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("deletede by oracle");
        }
    }

}
