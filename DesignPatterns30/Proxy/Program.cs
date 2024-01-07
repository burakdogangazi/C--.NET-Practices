using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    { //Çağırmak istediğimiz operasyon ya da kaynak sonucu yeniden çağırmadan kullanmak için cacheleme 
      // hesap aynı parametreler de yeniden yapılırsa cachedeki bilgini verilmesidir.
        static void Main(string[] args)
        {
            CreditBase manager = new CreditManagerProxy();
            Console.WriteLine(manager.Calculate()); // 5 saniyede oldu
            Console.WriteLine(manager.Calculate()); // aynı işem yine 5 saniye engellemek için proxy

            Console.ReadLine();

        }
    }


    abstract class CreditBase
    {

        public abstract int Calculate();

    }

    class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= i;
                Thread.Sleep(1000);
            }

            return result;
        }
    }

    class CreditManagerProxy : CreditBase
    {
        private CreditManager _creditManager;
        private int _cachedValue;

        public override int Calculate()
        {
            if(_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }

            return _cachedValue;
        }
    }





}
