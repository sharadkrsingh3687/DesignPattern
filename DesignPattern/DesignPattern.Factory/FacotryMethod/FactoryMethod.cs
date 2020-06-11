using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory.FactoryMethod
{
    public class MoneyBackFacotry: CreditCardFactory
    {
        CreditCard creditCard;
        protected CreditCard MakeProduct()
        {
            creditCard = new MoneyBack();
            return creditCard;
        }
    }

    public class TitaniamFactory: CreditCardFactory
    {
        CreditCard creditCard;
        protected  CreditCard MakeProduct()
        {
            creditCard = new Titaniam();
            return creditCard;
        }
    }

    public class PlatinamFactory: CreditCardFactory
    {
        CreditCard creditCard;

        protected CreditCard MakeProduct()
        {
            creditCard = new Platinam();
            return creditCard;
        }
    }
}
