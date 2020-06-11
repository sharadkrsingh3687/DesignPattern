using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class Titaniam : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 150;
        }

        public string GetCardType()
        {
            return "Titaniam Edge";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
