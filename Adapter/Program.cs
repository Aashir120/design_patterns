using System;

public class HelloWorld
{
    public interface Service{
        void Calculate();
        void GetLabels();
    }
    public class Shipment{
        public void GetCalculate(){
            System.Console.WriteLine("calculate");
        }
        public void GetShippingDetails(){
            System.Console.WriteLine("labels");
        }
    }
    public class EcommerceShipping: Service{
        private Shipment shipment;
        public EcommerceShipping(Shipment shipment){
            this.shipment = shipment;
        }
        public void Calculate(){
            shipment.GetCalculate();
        }
        public void GetLabels(){
            shipment.GetShippingDetails();
        }
    }

    public static void Main(string[] args)
    {
        var Shipment = new Shipment();
        var EcommerceShipping = new EcommerceShipping(Shipment);
        
        EcommerceShipping.Calculate();
        EcommerceShipping.GetLabels();
        
    }
}