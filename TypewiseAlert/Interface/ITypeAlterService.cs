using System;
using System.Collections.Generic;
using System.Text;
using TypewiseAlert.Enum;
using static TypewiseAlert.TypewiseAlert;

namespace TypewiseAlert.Interface
{
    public  interface ITypeAlterService
    {
        void SendAlter(BreachType breachType, AlertTarget alertTarget);
    }
}
