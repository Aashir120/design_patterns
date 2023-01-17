using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface HotelRoomFacade
    {
        void Book();
        void Checkout();
    }
    public class Customer : HotelRoomFacade
    {
        public void Book()
        {
            Console.WriteLine("book");
        }
        public void Checkout()
        {
            Console.WriteLine("checkout");
        }
    }
    public class Provider
    {
        private Customer customer;

        public Provider()
        {
            customer = new Customer();
        }
        public void Status()
        {
            customer.Book();
            customer.Checkout();
        }
    }


}

//Demo
//{
//    ServiceProvider serviceProvider = new ServiceProvider();

//    serviceProvider.GetStatus();
//}
