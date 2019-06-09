using System;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace RestaurantCheckout
{
    [Binding]
    public static class UnitTest1
       
    {
        public static double total;
        public static double updatedtotal;
        [Given(@"Calculate the total for (.*) starters and (.*) mains with total being (.*)")]
        public static void GivenCalculateTheTotalForStartersAndMainsWithTotalBeing(double totalStarters, double totalmains, double expectedresult)
        {
            total = Function.Add(totalStarters, totalmains);
            Assert.That(Math.Round(total, 2), Is.EqualTo(expectedresult));
        }


        
        [Then(@"Update the total for (.*) starters and (.*) mains with total being (.*) and old values being (.*) and (.*)")]
        public static  void ThenUpdateTheTotalForStartersAndMainsWithTotalBeingAndOldValuesBeingAnd(double updatedstarters, double updatedmains, double expectedresult, double actualstarters, double actualmains)
        {
            double totalstartersafterupdate = actualstarters + updatedstarters;
            double totalmainsafterupdate = actualmains + updatedmains;
            updatedtotal = Function.Update(totalstartersafterupdate, totalmainsafterupdate);
            Assert.That(Math.Round(updatedtotal, 2), Is.EqualTo(expectedresult));
        }





    }
}
