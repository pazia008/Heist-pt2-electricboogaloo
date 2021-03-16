using System.Collections.Generic;
using System;

namespace Heisting
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int HackerSkillz = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system! Secruity is decreased by {SkillLevel}.");
            if (HackerSkillz == 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!!");
            }
        }

    }

}