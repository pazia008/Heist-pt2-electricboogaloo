using System;

namespace Heisting
{

    public class Bank
    {
        public decimal CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure
        {
            get
            {
                if (AlarmScore < 0 && VaultScore < 0 && SecurityGuardScore < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }


}