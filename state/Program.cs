using System;

public class HelloWorld
{
    public interface State{
        void doAction();
    }
    public class IdleState:State{
        public void doAction(){
            System.Console.WriteLine("idle state");
        }
    }
    public class MoneyInsertState:State{
        public void doAction(){
            System.Console.WriteLine("money insert state");
        }
    }
    public class ProductState:State{
        public void doAction(){
            System.Console.WriteLine("product select state");
        }
    }
    public class Context{
        private State state;

        public Context(){
            state  = null;
        }
        public void setState(State state){
            this.state = state;
            this.state.doAction();
        }
        public State getState(){
            return state;
        }

    }

    public static void Main(string[] args)
    {
        Context context = new Context();

        IdleState obj = new IdleState();
        MoneyInsertState obj2 = new MoneyInsertState();

        context.setState(obj);
        context.setState(obj2);
        
    }
}