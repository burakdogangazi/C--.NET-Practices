using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods12
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            OracleServer oracleServer = new OracleServer();
            oracleServer.Add();

        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
            //virtual yazdık bunun içindeki kod maalesef sql de farklı ise
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted By Default");
        }

        //Eğer inheritance yaptın ama fonksiyon içeriğini ezmek istiyoruz bu sefer virtual kullanılır override ile
    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added By Sqlcode");
            //base.Add();
        }
    }

    class OracleServer:Database
    {

    }

}
