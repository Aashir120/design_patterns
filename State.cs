using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface State
    {
        void doAction();
    }
    public class IdleState : State
    {
        public void doAction()
        {
            Console.WriteLine("idle state");
        }
    }
    public class MoneyState : State
    {
        public void doAction()
        {
            Console.WriteLine("money inserted");
        }
    }

    public class Context
    {
        private State state;

        public Context()
        {
            state = null;
        }
        public void setState(State state)
        {
            this.state = state;
            this.state.doAction();
        }
        public State getState()
        {
            return state;
        }
    }
}

//Demo
//{

//    Context context = new Context();
//    IdleState idle = new IdleState();
//    MoneyState money = new MoneyState();
//    context.setState(idle);
//    context.getState();


//    context.setState(money);
//    context.getState();
//}