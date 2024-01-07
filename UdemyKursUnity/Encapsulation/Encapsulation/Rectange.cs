using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Rectange
    {
        public int a;
        private int _a;
        public int b;
        private int _b;

        public int A { 
            get { return _a; }
            set { 
            
                if(value < 0) // value biz tanımladaık set e gelen değer demek
                {
                    _a = 0;
                }

                else
                {
                    _a = value;
                }
            
            }
        }

        public int B {
            get { return -b; }
            set { 
            
                if(value < 0)
                {
                    _b = 0;
                }

                else
                {

                    _b = value;
                }
            }
        
        
        }


        
        public int CalculateArea()
        {
            return a * b;
        }

    }
}
