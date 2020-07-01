using AudenTechnicalTest.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AudenTechnicalTest.StepDefinition
{
    [Binding]
    public class LoanCalculatorSteps
    {
        CalculatorPO calculatorPO;
        public  LoanCalculatorSteps()
        {
            calculatorPO = new CalculatorPO();
        }

        [Given(@"I navigate to the site ""(.*)""")]
        public void GivenINavigateToTheSite(string url)
        {
            calculatorPO.NavigateToSite(url);
        }
        
        [Given(@"I select a loan amount")]
        public void GivenISelectALoanAmount()
        {
           calculatorPO.GetSliderAmount();
        }
        

      
        [When(@"I select a weekend")]
        public void WhenISelectAWeekend()
        {
            calculatorPO.SelectWeekend();
            calculatorPO.ClickFriday();
        }


        [Then(@"the first repayment date option should be prior friday")]
        public void ThenTheFirstRepaymentDateOptionShouldBePriorFriday()
        {
            // Assert.AreEqual(calculatorPO.GetLoanAmount, calculatorPO.GetValueSelected);
            Assert.AreEqual("Friday 3 Jul 2020", calculatorPO.GetRepaymentDate);
            Assert.AreEqual("200", calculatorPO.GetSliderMinValue);
            Assert.AreEqual("500", calculatorPO.GetSliderMaxValue);
        }
    }
}
