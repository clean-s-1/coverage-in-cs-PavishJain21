using System;
using TypewiseAlert.Enum;
using TypewiseAlert.Interface;
using TypewiseAlert.Struct;

namespace TypewiseAlert
{
    public static class TypewiseAlert
    {
    public static BreachType inferBreach(double value, double lowerLimit, double upperLimit) {
      if(value < lowerLimit ) {
        return BreachType.TOO_LOW;
      }
      if(value > upperLimit) {
        return BreachType.TOO_HIGH;
      }
      return BreachType.NORMAL;
    }

    public static BreachType classifyTemperatureBreach(
        CoolingType coolingType, double temperatureInC) {
      int lowerLimit = 0;
      int upperLimit = 0;
      switch(coolingType) {
        case CoolingType.PASSIVE_COOLING:
          lowerLimit = 0;
          upperLimit = 35;
          break;
        case CoolingType.HI_ACTIVE_COOLING:
          lowerLimit = 0;
          upperLimit = 45;
          break;
        case CoolingType.MED_ACTIVE_COOLING:
          lowerLimit = 0;
          upperLimit = 40;
          break;
      }
      return inferBreach(temperatureInC, lowerLimit, upperLimit);
    }
  
  
    public static void checkAndAlert(
        AlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC) {

      BreachType breachType = classifyTemperatureBreach(
        batteryChar.coolingType, temperatureInC
      );
            ITypeAlterService alterService = new TypeAlertService();
            alterService.SendAlter(breachType, alertTarget);
    }
   
  }
}
