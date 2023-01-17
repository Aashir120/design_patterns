using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface Stock
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
    }
    public class Market : Stock
    {
        private List<Observer> _observer = new List<Observer>();
        private int price;

        public void Attach(Observer observer)
        {
            _observer.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observer.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in _observer)
            {
                observer.Update(price);
            }
        }
        public void GetPrice(int price)
        {
            this.price = price;
            Notify();
        }
    }
    public interface Observer
    {
        void Update(int price);
    }
    public class Client : Observer
    {
        private string name;
        public Client(string name)
        {
            this.name = name;
        }
        public void Update(int price)
        {
            Console.WriteLine(name+" "+price);
        }

    }
}

//Demo
//{
//    Market market = new Market();
//    Client client1 = new Client("aashir");
//    Client client2 = new Client("ali");
//    market.Attach(client1);
//    market.Attach(client2);

//    market.GetPrice(1000);
//}