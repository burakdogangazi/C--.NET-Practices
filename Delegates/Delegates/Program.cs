using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();// elçi void döndüren ve paramtre almayan operasyonlara delegelik yapıyor
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1,int number2);


    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.SendAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.SendAlert;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.SendAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;

            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);

            //Action bir metoda denk gelir void tipinde
            // 
            
            
            

            //myDelegate2("Hello");// ikisine de aynı değeri gönderebiliyoruz ancak

            //myDelegate();
            
            
            
           // Console.ReadLine();

        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void SendAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void SendAlert2(string alert)
        {
            Console.WriteLine(alert);
        }

    }

    public class Matematik
    {

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }


        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }



    }


}
