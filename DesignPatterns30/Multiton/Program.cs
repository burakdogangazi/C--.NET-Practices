using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiton
{
    class Program
    {// singleton geliştirilmiş ve çoğul singletondur
        //singletonda 1 nesneden 1 kere üretilirdi belli şarta göre
        //instance üretlilip o şartı sağlayanlara o nesnenin verilmesidir.
        // singleton 100 istek tek nesne 
        // multiton her parametreye bir instance üretilir.
        static void Main(string[] args)
        {

            Camera camera1 = Camera.GetCamera("NIKON");// AYNI değere sahipler aynı instance alır
            Camera camera2 = Camera.GetCamera("NIKON");
            Camera camera3 = Camera.GetCamera("CANON");
            Camera camera4 = Camera.GetCamera("CANON");
            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera1.Id);
            Console.WriteLine(camera1.Id);

            // AYNI değere sahipler aynı instance alıdı nikonlar aynı id ve canonlar ayni id dir.

            Console.ReadLine();
        
        }
    }

    class Camera // nikon için tek intane // kanon için tek instance ...
    {

        static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>();
        
        static object _lock = new object();

        public Guid Id { get; set; }


        private Camera()
        {
            Id = Guid.NewGuid();

        }

        public static Camera GetCamera(string brand)
        {
            lock (_lock)
            {
                if (!_cameras.ContainsKey(brand))
                {
                    _cameras.Add(brand,new Camera());
                }

                return _cameras[brand];
            }
        }


    }
}
