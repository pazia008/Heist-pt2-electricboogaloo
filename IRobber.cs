using System.Collections.Generic;
using System;

namespace Heisting
{
    public interface IRobot
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }

        void PerformSkill(Bank bank);

    }
}