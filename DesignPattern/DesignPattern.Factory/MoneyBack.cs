using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 350;
        }

        public string GetCardType()
        {
            return "Money Back";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
