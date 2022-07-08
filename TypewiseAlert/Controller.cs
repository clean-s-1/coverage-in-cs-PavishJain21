using System;
using System.Collections.Generic;
using System.Text;
using TypewiseAlert.Interface;
using TypewiseAlert.Enum;
namespace TypewiseAlert
{
    public class Controller : IBreachStrategy
    {
        public  void SendAsPerBrachType(BreachType breachType)
        {
            Console.WriteLine("Breach Type is", breachType);
        }
    }

}
