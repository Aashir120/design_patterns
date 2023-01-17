using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface CarBuilder
    {
        void Color();
        void Engine();
        void Transmission();

        Vehicle GetVehicle();
    }

    public class BMW : CarBuilder
    {
        private Vehicle vehicle;

        public BMW()
        {
            vehicle = new Vehicle();
        }

        public void Color() {

            vehicle.Color = "blue";
        }
        public void Engine() {

            vehicle.Engine= "BMW";
        }
        public void Transmission() {

            vehicle.Transmission = "1000";
        }

        public Vehicle GetVehicle()
        {
            return vehicle;
        }
    }

    public class Vehicle
    {
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Transmission{ get; set; }
    }

    public class VehicleMaker
    {
        private CarBuilder car;
        public VehicleMaker(CarBuilder car)
        {
            this.car = car;
        }

        public void Make()
        {
            car.Color();
            car.Engine();
            car.Transmission();
        }
        public Vehicle GetVehicle()
        {
            return car.GetVehicle();
        }
    }
}

//Demo
//{
//    BMWVehicleBuilder bMW = new BMWVehicleBuilder();
//    VehicleMaker vehicleMaker = new VehicleMaker(bMW);

//    vehicleMaker.BuildVehicle();
//    Vehicle vehicle = vehicleMaker.GetVehicle();

//    Console.WriteLine(vehicle.body);
//} 


//public interface VehicleBuilder
//{
//    void AddWheels();
//    void AddEngine();
//    void AddBody();
//    void AddColor();

//    Vehicle GetVehicle();
//}

//public class BMWVehicleBuilder : VehicleBuilder
//{
//    private Vehicle vehicle;

//    public BMWVehicleBuilder()
//    {
//        vehicle = new Vehicle();
//    }

//    public void AddWheels()
//    {
//        vehicle.wheels = "alloy";
//    }
//    public void AddEngine()
//    {
//        vehicle.engine = "bmw";
//    }
//    public void AddBody()
//    {
//        vehicle.body = "steel";
//    }
//    public void AddColor()
//    {
//        vehicle.color = "black";
//    }
//    public Vehicle GetVehicle()
//    {
//        return vehicle;
//    }
//}
//public class Vehicle
//{
//    public string wheels { get; set; }
//    public string engine { get; set; }
//    public string body { get; set; }
//    public string color { get; set; }
//}

//public class VehicleMaker
//{
//    private VehicleBuilder vehicleBuilder;
//    public VehicleMaker(VehicleBuilder vehicleBuilder)
//    {
//        this.vehicleBuilder = vehicleBuilder;
//    }

//    public void BuildVehicle()
//    {
//        vehicleBuilder.AddWheels();
//        vehicleBuilder.AddEngine();
//        vehicleBuilder.AddBody();
//        vehicleBuilder.AddColor();
//    }

//    public Vehicle GetVehicle()
//    {
//        return vehicleBuilder.GetVehicle();
//    }
//}