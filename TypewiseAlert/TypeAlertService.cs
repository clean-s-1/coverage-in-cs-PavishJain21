using System;
using System.Collections.Generic;
using System.Text;
using TypewiseAlert.Enum;
using TypewiseAlert.Interface;
using static TypewiseAlert.TypewiseAlert;

namespace TypewiseAlert
{
    public class TypeAlertService : ITypeAlterService
    {
        public IBreachStrategy _BreachStrategy;
        public void SendAlter(BreachType breachType, Enum.AlertTarget alertTarget)
        {
            switch (alertTarget)
            {
                case Enum.AlertTarget.TO_CONTROLLER:
                    _BreachStrategy = new Controller();
                    break;
                case AlertTarget.TO_EMAIL:
                    _BreachStrategy = new Email();
                    break;
            }
            _BreachStrategy.SendAsPerBrachType(breachType);
        }
        
    }
}
