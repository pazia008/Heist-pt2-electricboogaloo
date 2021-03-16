using System.Collections.Generic;
using System;

namespace Heisting
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int HackerSkillz = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is beating up some Big Tough Guys! Secruity is decreased by {SkillLevel}.");
            if (HackerSkillz == 0)
            {
                Console.WriteLine($"{Name} handled the security guards!!");
            }
        }
    }

}