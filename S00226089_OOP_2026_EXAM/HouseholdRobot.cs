using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00226089_OOP_2026_EXAM
{
    internal class HouseholdRobot : Robots
    {
        private List<HouseholdSkill> Skills;

        public HouseholdRobot(string robotName, double powerCapacityKWH, double currentPowerKWH, string robotDescription)
        {
            RobotName = robotName;
            PowerCapacityKWH = powerCapacityKWH;
            CurrentPowerKWH = currentPowerKWH;
            RobotDescription = robotDescription;
        }
        public override string DescribeRobot()
        {
            return "I am a household robot.\nI can help with chores around the house.\n\nHousehold Robot Skills: \n" + Skills.ToString() + DisplayBatteryInformation().ToString();
        }
        public HouseholdSkill DownloadSkill()
        {
            if (RobotName == "GardenMate") Skills.Add(HouseholdSkill.Gardening);

            if (RobotName == "HouseMate 3000") 
            { 
                Skills.Add (HouseholdSkill.Cooking);
                Skills.Add ()
            
            }
        }
    }
}
