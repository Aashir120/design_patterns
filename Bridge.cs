using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface Order
    {
        void Process();
    }
    public interface OrderApi
    {
        string Take();
    }
    public class API : OrderApi
    {
        public string Take()
        {
            return "order is taking";
        }
    }
    public class USOrder : Order
    {
        private OrderApi OrderApi;

        public USOrder(OrderApi orderApi)
        {
            this.OrderApi = orderApi;
        }
        public void Process()
        {
            OrderApi.Take();
        }
    }
    

}

//Demo
//{
//    API aPI = new API();
//    Order order = new Online(aPI);
//    Console.WriteLine(order.Take());
//}


//public interface Order
//{
//    public string Take();
//}
//public class Online : Order
//{
//    private OrderApi orderApi;

//    public Online(OrderApi orderApi)
//    {
//        this.orderApi = orderApi;
//    }
//    public string Take()
//    {
//        return orderApi.TakeOrder();
//    }


//}
//public interface OrderApi
//{
//    string TakeOrder();
//}
//public class API : OrderApi
//{
//    public string TakeOrder()
//    {
//        return "order is made online";
//    }

//}