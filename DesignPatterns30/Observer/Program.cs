using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    { // kullanıcının ilgilendiği ürünün fiyatının düştüğünde uyarılması 
        static void Main(string[] args)
        {
            var customerObserver = new CustomerObserver();
            ProductManager productManager = new ProductManager();
            productManager.Attached(customerObserver);
            productManager.Attached(new EmployeeObserver());
            productManager.Detach(customerObserver);
            productManager.UpdatePrice();
            Console.ReadLine();

        }
    }

    class ProductManager
    {
        List<Observer> _observers = new List<Observer>();

        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed");
            Notify();
        }

        public void Attached(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }



    }


    abstract class Observer
    {
        public abstract void Update();
    }

    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Prdocut price changed");

        }
    }

    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee : Prdocut price changed");

        }
    }



}
