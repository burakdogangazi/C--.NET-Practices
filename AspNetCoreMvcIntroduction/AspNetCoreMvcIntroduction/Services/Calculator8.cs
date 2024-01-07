using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Services
{
    public class Calculator8 : ICalculator
    {
        public decimal Calculate(decimal amount)
        {
            return amount + (amount * 8 / 100);
        }
    }
}
