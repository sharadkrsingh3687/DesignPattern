using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class Platinam : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 250;
        }

        public string GetCardType()
        {
            return "Platinam Plus";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
