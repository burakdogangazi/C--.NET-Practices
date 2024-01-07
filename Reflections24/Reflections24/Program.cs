using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections24
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla(3, 4);
            //dortIslem.Topla2();

            //Reflection çalışma anı değerlere bakmak

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7); // 13.satırdaki new ile aynı

            //dortIslem.Topla(3, 4);

            //dortIslem.Topla2();// 6 ve 7 kullanır ctor istiyor.


            var instance = Activator.CreateInstance(type, 6, 7);

            instance.GetType().GetMethod("Topla2").Invoke(instance,null); //13
                                                                          // tipin metoduna oluşup çağırabiliyoruz


            var metodlar = type.GetMethods();

            foreach (var metod in metodlar)
            {
                Console.WriteLine("Metod Adı : {0}",metod.Name);
                foreach (var paramater in metod.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", paramater);

                }

                foreach (var attr in metod.GetCustomAttributes())
                {
                    Console.WriteLine("Attr : {0}", attr.GetType().Name);
                }


            }



        }
    }

    class MetodNameAttribute:Attribute
    {
        public MetodNameAttribute(string Name)
        {
                
        }
    }


    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;

        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }


    }
    
}
