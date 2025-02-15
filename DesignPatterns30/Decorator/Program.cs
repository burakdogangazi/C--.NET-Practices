﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    { // Araba kiralamada bazi dönemlerde bazı müşteriler için özel koşullar oluşturmak istiyoruz örnek olarak
        // bu şartlarda kullanılabilir
        static void Main(string[] args)
        {//araba tipine özel indirimde bulunduk


            var personalCar = new PersonalCar { Make ="BMW" ,Model ="3.20",HirePrice=2500};

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;
            Console.WriteLine("CONCRETE : {0}", personalCar.HirePrice);
            Console.WriteLine("Special offerdan gelen : {0}",specialOffer.HirePrice);


            Console.ReadLine();
        }
    }


    abstract class CarBase
    {
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }

    class PersonalCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    class CommercialCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice { get; set; }
    }

    abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }


        private readonly CarBase _carBase1;
        public SpecialOffer(CarBase carBase):base(carBase)
        {

        }

        public override string Make { get; set; }
        public override string Model { get; set; }
        public override decimal HirePrice {

            get
            {
                return _carBase1.HirePrice -_carBase1.HirePrice *DiscountPercentage/100;

            }


            set 
            {


            }
        }
    }



}
