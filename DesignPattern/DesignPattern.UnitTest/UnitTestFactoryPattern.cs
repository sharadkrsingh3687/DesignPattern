using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DesignPattern.Factory;
using FactoryMethod = DesignPattern.Factory.FactoryMethod;
namespace DesignPattern.UnitTest
{
    [TestClass]
    public class UnitTestFactoryPattern
    {
        [TestMethod]
        public void TestFactoryMethodDesignPattern()
        {
            CreditCard creditCard;

            creditCard = new FactoryMethod.MoneyBackFacotry().CreateProduct();

            Assert.IsNotNull(creditCard);
            Assert.IsInstanceOfType(creditCard, typeof(MoneyBack));

        }
    }
}
