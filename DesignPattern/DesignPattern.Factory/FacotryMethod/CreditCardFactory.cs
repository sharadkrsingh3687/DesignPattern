using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.Factory;

namespace DesignPattern.Factory.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
