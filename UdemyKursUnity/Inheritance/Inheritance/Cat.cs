using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal// animal özel ve fonklarını aktar
    {
        public int runSpeed;
        public string sound;

        public string GetProperties()
        {   // base anahtar kelimesi bunun üretildiği sınıf demektir.
            
            string animalProperties = base.GetProperties();
            string catProperties = string.Format("Run speed : {0} Sound : {1}  ", runSpeed, sound);
            return animalProperties + catProperties;


        }

        public override void Move()
        {
            
        }

        public override void Sleep()
        {
            energy += 2;
        }

    }
}
