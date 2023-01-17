using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   public interface PayrollSystem
    {
        void Show();
    }
    public class Manager: PayrollSystem
    {
        private string name;
        public Manager(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine("employees payroll");
        }
    }
    public class PayrollProxy : PayrollSystem
    {
        private Manager manager;

        private string role;
        private string name;
        public PayrollProxy(string role,string name)
        {
            this.role = role;
            this.name = name;
        }
        public void Show()
        {
            if(role == "manager")
            {
                manager = new Manager(name);
            }
            else
            {
                Console.WriteLine("you dont have access");
            }
        }
    }

}

//Demo
//{
//    PayrollProxy payrollProxy = new PayrollProxy("manager", "aashir");
//    payrollProxy.Show();
//}