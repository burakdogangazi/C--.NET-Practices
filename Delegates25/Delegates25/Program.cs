using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates25
{

    public delegate void MyDelegate(); // void döndüren ve parametre almayan operasyonlara delegelik yapıyor 
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    //Delegeler Belli metodları toplayıp çıkararak sıra ile uygulanmasını kolaylaştırır yemek tarifi gibi
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessages();
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessages;
            myDelegate += customerManager.ShowAlert;


            myDelegate -= customerManager.SendMessages;

            MyDelegate2 myDelegate2 = customerManager.SendMessages2;

            myDelegate2 += customerManager.ShowAlert2;


            Matematik matematik = new Matematik();


            MyDelegate3 myDelegate3 = matematik.Topla;

            myDelegate3 += matematik.Carp; // topla mı kullanacak delege carp mı 
            // en son carp eklenen oldugu için çarp kullanır


            var sonuc = myDelegate3(2, 3);

           
            
            myDelegate2("Hello");




            myDelegate();//hello





        }
    }

    public class CustomerManager
    { 
    
        public void SendMessages()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Carefur");
        }

        public void SendMessages2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
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
