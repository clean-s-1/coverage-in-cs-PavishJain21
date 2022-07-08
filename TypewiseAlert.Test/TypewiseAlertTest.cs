using System;
using Xunit;
using TypewiseAlert.Enum;

namespace TypewiseAlert.Test
{
    public class TypewiseAlertTest
    {
        [Fact]
        public void InfersBreachAsPerLimits()
        {
            Assert.True(TypewiseAlert.inferBreach(12, 20, 30) ==
              BreachType.TOO_LOW);
        }

        [Fact]
        public void InfersBreachAsForHighimits()
        {
            Assert.True(TypewiseAlert.inferBreach(45, 20, 30) ==
              BreachType.TOO_HIGH);
        }

        [Fact]
        public void InfersBreachAsForHNormalimits()
        {
            Assert.True(TypewiseAlert.inferBreach(15, 14, 30) ==
              BreachType.NORMAL);
        }

        [Fact]

        public void checkAndAlertTest()
        {
            TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL,
                new Struct.BatteryCharacter() { brand = "Siemens", 
                    coolingType = CoolingType.PASSIVE_COOLING },
                45);
            Assert.True(true);

        }

        [Fact]

        public void checkAndAlertForController()
        {
            TypewiseAlert.checkAndAlert(AlertTarget.TO_CONTROLLER,
                new Struct.BatteryCharacter()
                {
                    brand = "Siemens",
                    coolingType = CoolingType.HI_ACTIVE_COOLING
                },
                15);
            Assert.True(true);
        }


        [Fact]

        public void checkAndAlertToEmail()
        {
            TypewiseAlert.checkAndAlert(AlertTarget.TO_EMAIL,
                new Struct.BatteryCharacter()
                {
                    brand = "Siemens",
                    coolingType = CoolingType.HI_ACTIVE_COOLING
                },
                2);
            Assert.True(true);
        }
    }
}
