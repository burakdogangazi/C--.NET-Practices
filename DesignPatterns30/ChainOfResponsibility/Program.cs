using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {// Şirketteki harcamalar 100 lira altındaysa müdür yetki verebilir 1000 lira üzeri başkan yardımcısı onay verir daha syükseklerine direk başkan izin ver.
       //Evrak takip deseni
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            VicePresident vicePresident = new VicePresident();
            President president = new President();

            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Expense expense = new Expense { Amount = 98, Detail = "Tranining" };
            manager.HandleExpense(expense);

            Console.ReadLine();

        }
    }

    class Expense
    {
        public string Detail { get; set; }
        public decimal Amount { get; set; }

    }

    abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase successor;

        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            this.successor = successor;
        }

        public abstract void HandleExpense(Expense expense);
    }

    class Manager : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if(expense.Amount <= 100)
            {
                Console.WriteLine("Manager handled the expense!");
            }

            else if(successor != null)
            {
                successor.HandleExpense(expense);
            }
            
        }
    }

    class VicePresident : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {

            if (expense.Amount > 100 && expense.Amount <=1000)
            {
                Console.WriteLine("Vice President handled the expense!");
            }

            else if (successor != null)
            {
                successor.HandleExpense(expense);
            }

        }
    }

    class President : ExpenseHandlerBase
    {
        public override void HandleExpense(Expense expense)
        {
            if (expense.Amount > 1000)
            {
                Console.WriteLine("President handled the expense!");
            }

            else if (successor != null)
            {
                successor.HandleExpense(expense);
            }

        }
    }





}
