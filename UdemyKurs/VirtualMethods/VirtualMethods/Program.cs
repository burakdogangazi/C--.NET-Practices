using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySql = new MySqlServer();
            mySql.Add();

            // sen bir sınıfıtan 2 sınıf türettin implemantasyonu yaptın
            // eğer ana sınıftaki metodu çağırırsan ana metodgelir default yazar ama virtual yazıp kendi sınıfında override ederse o yazar.

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }

    }


    class SqlServer: Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by sql code");

            //base.Add();
        }
    }

    class MySqlServer : Database
    {

    }

}
