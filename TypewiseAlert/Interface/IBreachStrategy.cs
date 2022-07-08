using System;
using System.Collections.Generic;
using System.Text;
using TypewiseAlert.Enum;

namespace TypewiseAlert.Interface
{
    public interface IBreachStrategy
    {
        void SendAsPerBrachType(BreachType breachType);
    }
}
