using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {//Bağımlılığı kaldırmak dependency inversion bu yasayı
     //yağa kaldıran bir desenlerden biri dependency injection
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();// bin kişi aynı isntance verir singelton ile her zaman oluşturmaz. 1000 kere


            //ProductManager productManager = new ProductManager(new EfProductDal());
            ProductManager productManager = new ProductManager(kernel.Get<IProductDal>());
            productManager.Save();

            Console.ReadLine();
        }
    }



    interface IProductDal
    {
        void Save();
    }
    class EfProductDal:IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Ef");
        }

    }

    class NHProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with NH");
        }

    }

    class ProductManager
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Save()
        {
            //Business Code

            _productDal.Save();
            
        }
    }


}
