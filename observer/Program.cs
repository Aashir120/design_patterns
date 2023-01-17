using System.Net.Sockets;
using System;

public class HelloWorld
{
    public interface Stock{
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }

    public interface Observer{
        void Update(int price);
    }

    public class Market:Stock{
        private List<Observer> _observer = new List<Observer>();

        private int price;

        public void Attach(Observer observer){
            _observer.Add(observer);
        }

        public void Detach(Observer observer){
            _observer.Remove(observer);
        }

        public void Notify(){
            foreach (Observer observer in _observer)
            {
                observer.Update(price);
            }
        }
        public void PostPrice(int price){
            this.price = price;
            Notify();
        }
    }
    public class Client:Observer{
        private string name;

        public Client(string name){
            name = name;
        }
        public void Update(int price){
            System.Console.WriteLine(name+" "+price);
        }
    }

    public static void Main(string[] args)
    {
        
        Market market = new Market();
        Client obj1 = new Client("1");
        Client obj2 = new Client("2");

        market.Attach(obj1);
        market.Attach(obj2);

        market.PostPrice(1000);

    }
}