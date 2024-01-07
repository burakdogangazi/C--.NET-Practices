using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Services
{
    public class Calculator18 : ICalculator
    { // startup içinde scoped içinde bu calculate değerini gösterdik.
        public decimal Calculate(decimal amount)
        {
            return amount + (amount * 18 / 100);
        }
    }
}
