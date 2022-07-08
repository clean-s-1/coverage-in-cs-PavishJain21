using System;
using System.Collections.Generic;
using System.Text;
using TypewiseAlert.Interface;
using TypewiseAlert.Enum;
namespace TypewiseAlert
{
    public class Email : IBreachStrategy
    {
        public void SendAsPerBrachType(BreachType breachType)
        {
            string recepient = "ab@c.com";
            switch (breachType)
            {
                case BreachType.TOO_LOW:
                    Console.WriteLine("To", recepient);
                    Console.WriteLine("Hi, the temperature is too low\n");
                    break;
                case BreachType.TOO_HIGH:
                    Console.WriteLine("To", recepient);
                    Console.WriteLine("Hi, the temperature is too high\n");
                    break;
                case BreachType.NORMAL:
                    Console.WriteLine("To", recepient);
                    Console.WriteLine("Hi, the temperature is Normal\n");
                    break;
            }
        }
    }
}
