using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Factory;
using FacotryMethodNamespace = DesignPattern.Factory.FactoryMethod;

namespace DesignPattern.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string CardType;

            CreditCard CardDetails;

            System.Console.Write("Enter the Card Type:");
            CardType = System.Console.ReadLine();

            CreditCardFactory creditCardFactory = new CreditCardFactory();
            CardDetails = creditCardFactory.GetCreditCard(CardType);

            CardDetails = new FacotryMethodNamespace.MoneyBackFacotry().CreateProduct();

            System.Console.WriteLine("Print Card Details:");
            System.Console.WriteLine("Card Type: {0}\nCard Limit: {1}\nCard Annual Charge: {2}",
                CardDetails.GetCardType(),
                CardDetails.GetCreditLimit(),
                CardDetails.GetAnnualCharge());

            System.Console.ReadKey();




        }
    }
}
