using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // çalışma anaında düzeltme yapabilmek reflection
            //  DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla2(); constructor ile değer gerektirmez

            var tip = typeof(DortIslem);

            // var dortIslem = Activator.CreateInstance(tip);// new lemek ile aynı anlam
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);// const değerleri yazmazsan program çalşırken const değerlerini arar
            //dortIslem.Topla(4, 5);  olan metodlu
            //Console.WriteLine(dortIslem.Topla2()); parametresiz

            var instance = Activator.CreateInstance(tip, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");//parametre olmadığı için null invoke ile bu metodu çalıştır dedik

            Console.WriteLine(methodInfo.Invoke(instance, null);

            var metodlar = tip.GetMethods();

            foreach(var info in metodlar)
            {
                Console.WriteLine("Metod adı: {}", info.Name);
                foreach(var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parameterInfo.Name);
                }

                foreach (var atts in info.GetCustomAttribute())
                {
                    Console.WriteLine("Attribute Name: {0}", atts.GetType().Name);
                }


            }


        }
    }


    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Topla2(int sayi1, int sayi2)
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2(int sayi1, int sayi2)
        {
            return _sayi1 + _sayi2;
        }



    }
}
