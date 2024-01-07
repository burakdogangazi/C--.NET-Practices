using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {

        void add();
        void update();
        void delete();

    }

    class SqlServerCusotmerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("Sql updated")
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }
    class OracleCusotmerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("Oracle updated")

        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }
    }

    class CustomerManager
    {
        public void add(ICustomerDal customerDal)
        {
            customerDal.add();
        }
    }


}
