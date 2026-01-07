using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00226089_OOP_2026_EXAM
{
    abstract class Robots
    {
        public string RobotName { get; set; }

        public double PowerCapacityKWH { get; set; }

        public double CurrentPowerKWH { get; set; }

        public string RobotDescription { get; set; }

        public double GetBatteryPercentage() 
        { 
            return CurrentPowerKWH/PowerCapacityKWH;
        }

        public string DisplayBatteryInformation() 
        {
            return 
                $"Battery Information: \n Capacity: " + this.PowerCapacityKWH.ToString() + 
                "\nCurrent Power: " + this.CurrentPowerKWH.ToString() + 
                "\n Battery Level: " + GetBatteryPercentage().ToString();
        }
        public abstract string DescribeRobot();


        public override string ToString()
        {
            return $"{RobotName} {RobotType}";
        }
        public enum HouseholdSkill {Cooking, Cleaning, Laundry, Gardening, ChildCare }

        public enum DeliveryMode {Walking, Driving, Flying }
    }
}
