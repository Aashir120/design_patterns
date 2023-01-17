using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface LegacySystem
    {
        void processData();
    }
    public class NewSystem
    {
        public void GetProcessData()
        {
            Console.WriteLine("legacy process data");
        }
    }
    public class LegacyAdapter : LegacySystem
    {
        private NewSystem newSystem;
        public LegacyAdapter(NewSystem newSystem)
        {
            this.newSystem = newSystem;
        }
        public void processData()
        {
            newSystem.GetProcessData();
        }
    }
}

//Demo
//{
//    NewSystem system = new NewSystem();
//    LegacyAdapter legacy = new LegacyAdapter(system);
//    legacy.processData();
//}