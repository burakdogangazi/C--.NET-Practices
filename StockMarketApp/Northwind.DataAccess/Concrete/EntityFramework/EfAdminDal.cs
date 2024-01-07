using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal:IAdminDal
    {

        public void IsCorrect(string username, string password)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
               
                
            }
        }

        public void IsCorrect(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
