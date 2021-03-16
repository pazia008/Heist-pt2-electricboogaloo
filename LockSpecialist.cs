using System.Collections.Generic;
using System;

namespace Heisting
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int HackerSkillz = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is picking them locks! Secruity is decreased by {SkillLevel}.");
            if (HackerSkillz == 0)
            {
                Console.WriteLine($"{Name} has cracked the vault!!");
            }
        }


    }

}