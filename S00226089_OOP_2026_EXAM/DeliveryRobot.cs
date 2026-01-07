using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00226089_OOP_2026_EXAM
{
    internal class DeliveryRobot : Robots
    {
        // delivery robot parameters
        public DeliveryMode delivery;
        public double MaxLoadKG;


        //delivery robot constructor
        public DeliveryRobot(string robotName, double powerCapacityKWH, double currentPowerKWH, string robotDescription, double maxLoadKG, DeliveryMode deliveryMode)
        {
            RobotName = robotName;
            PowerCapacityKWH = powerCapacityKWH;
            CurrentPowerKWH = currentPowerKWH;
            RobotDescription = robotDescription;
            MaxLoadKG = maxLoadKG;
            delivery = deliveryMode;
        }

        public override string DescribeRobot()
        {
            return $"{RobotDescription}\nI specialise in delivery by {delivery.ToString()}\n The maximum load I can carry is {MaxLoadKG.ToString()}\n{DisplayBatteryInformation().ToString()}";
        }
    }
}
