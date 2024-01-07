using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {//Orm modified state added state buna örnek olarak verilebilir.
        static void Main(string[] args)
        {
            Context context = new Context();
            ModifiedState modifiedState = new ModifiedState();
            modifiedState.DoAction(context);

            DeletedState deleted = new DeletedState();
            deleted.DoAction(context);


            Console.WriteLine(context.GetState());
            Console.ReadLine();
            // son state ne olduğunu tutar.

        }
    }

    interface IState
    {
        void DoAction(Context context);
    }

    class ModifiedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State: ModifiedState");
            context.SetState(this);
        }

        


    }

    class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State: Deleted");
            context.SetState(this);
        }
    }

    class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State: Added");
            context.SetState(this);
        }
    }


    class Context
    {
        private IState _state;
        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetState()
        {
            return _state;
        }

    }
}
