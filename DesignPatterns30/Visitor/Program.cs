using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {// Birbirlerini çağırması hiyerarşide farklı maaşlar verilmesi hiyerarşideki yapısına göre
        static void Main(string[] args)
        {
            Manager burak = new Manager { Name = "Burak", Salary = 1000 };
            Manager metin = new Manager { Name = "Metin", Salary = 900 };

            Worker aziz = new Worker { Name = "Aziz", Salary = 800 };
            Worker yeliz = new Worker { Name = "Burak", Salary = 700 };

            burak.Subordinates.Add(metin);
            metin.Subordinates.Add(aziz);
            metin.Subordinates.Add(yeliz);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(burak);

            PayrollVisitor payrollVisitor = new PayrollVisitor();

            Payrise payrise = new Payrise();

            organisationalStructure.Accept(payrollVisitor);
            organisationalStructure.Accept(payrise);

            Console.ReadLine();
        }
    }

    class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);

            


        }
    }

    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }

    }

    class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }
        public List<EmployeeBase> Subordinates { get; set; }
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
            foreach (var employee in Subordinates)
            {
                employee.Accept(visitor);
            }
        }
    }

    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }

    abstract class VisitorBase
    {
         abstract public void Visit(Worker worker);
        abstract public void Visit(Manager manager);

    }

    class PayrollVisitor : VisitorBase
    {

        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}", worker.Name, worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }

    }

    class Payrise : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary*(decimal)1.1);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0}salary increased to {1}", manager.Name, manager.Salary * (decimal)1.2);
        }
    }


}
