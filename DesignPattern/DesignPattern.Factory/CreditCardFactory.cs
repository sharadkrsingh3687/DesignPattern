using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class CreditCardFactory
    {
        public CreditCard GetCreditCard(string cardType)
        {
            CreditCard CardDetails;

            switch (cardType)
            {
                case "MoneyBack":
                    CardDetails = new MoneyBack();
                    break;
                case "Platinam":
                    CardDetails = new Platinam();
                    break;
                case "Titaniam":
                    CardDetails = new Titaniam();
                    break;
                default:
                    CardDetails = null;
                    break;
            }
            return CardDetails;
        }
    }
}
