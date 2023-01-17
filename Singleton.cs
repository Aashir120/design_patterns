using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class StockMarketData
    {
        private static StockMarketData instance = null;
        private static readonly object padlock = new object();

        private StockMarketData() { }
        public static StockMarketData GetStockMarketData()
        {
            lock (padlock)
            {
                if(instance == null)
                {
                    return new StockMarketData();
                }
                return instance;
            }
        }
    }
    
}


//Demo
//{
//    RoboticArm obj = RoboticArm.GetRobotic();

//    if (obj.IsInUse())
//    {
//        Console.WriteLine("already in use");
//    }
//    else
//    {
//        obj.StartUse();
//        Console.WriteLine("using");
//        obj.StopUse();
//    }
//}

//public class RoboticArm
//{
//    private static RoboticArm instance = null;
//    private static readonly object padlock = new object();
//    private bool isInUse = false;

//    private RoboticArm() { }

//    public static RoboticArm GetRobotic()
//    {
//        lock (padlock)
//        {

//            if (instance == null)
//            {
//                return new RoboticArm();
//            }
//            return instance;
//        }
//    }
//    public bool IsInUse()
//    {
//        return isInUse;
//    }
//    public void StartUse()
//    {
//        if (!isInUse)
//        {
//            isInUse = true;
//            Console.WriteLine("start using it ");
//        }
//        else
//        {
//            Console.WriteLine("already in use");
//        }
//    }
//    public void StopUse()
//    {
//        if (isInUse)
//        {
//            isInUse = false;
//            Console.WriteLine("now free ");
//        }
//        else
//        {
//            Console.WriteLine("already in use");
//        }
//    }
//}