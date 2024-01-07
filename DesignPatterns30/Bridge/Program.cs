using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {//Değiştirilebilir nesenleri soyutlamak.
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.messageSenderBase = new EMailSender();
            customerManager.UpdateCustomer();
            Console.ReadLine();

        }
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved");
        }

        public abstract void Send(Body body);

    }
    class Body
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class SmsSender : MessageSenderBase
    {

        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via Smssender",body.Title);
        }
    }

    class EMailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via Emailsender", body.Title);
        }
    }

    class CustomerManager
    {
        public MessageSenderBase messageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            messageSenderBase.Send(new Body { Title ="About the course"});
            Console.WriteLine("Customer updated");
        }

    }

    class NewCustomerManager : CustomerManager 
    { 
    }



}
