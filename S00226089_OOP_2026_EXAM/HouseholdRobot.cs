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

            //default on all household robots
            Skills.Add(HouseholdSkill.Cleaning);
        }
        public override string DescribeRobot()
        {
            return RobotDescription + "Household Robot Skills: \n" + Skills.ToString() + DisplayBatteryInformation().ToString();
        }

        //method to attach skills to given robots, document suggested putting in delivery robot however its used in here
        public void DownloadSkill()
        {
            if (RobotName == "GardenMate") Skills.Add(HouseholdSkill.Gardening);

            if (RobotName == "HouseMate 3000")
            {
                Skills.Add(HouseholdSkill.Cooking);
                Skills.Add(HouseholdSkill.Laundry);
            }
        }
    }
}
