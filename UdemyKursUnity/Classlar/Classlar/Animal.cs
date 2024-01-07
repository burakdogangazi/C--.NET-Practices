using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    public class Animal
    {

        Animal()
        {
            weight = -1;
            name = "Not defined";
            gender = -1;
        }

        public int weight;
        public string name;
        public int gender;

        public string GetAnimalProperties()
        {
            //return "weight" + weight + " name" + name + " gender : " + gender;

            return string.Format("Weight : {0} Name : {1} Gender: {2} ", weight, name, gender);
        
        }
    }
}
