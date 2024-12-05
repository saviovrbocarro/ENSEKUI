using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Screens
{
    public class SaleConfirmedPage : PagesBase
    {
        public IWebElement SaleConfirmedTitle => _driver.FindElement(By.CssSelector("div[class='container body-content']")).FindElement(By.TagName("h2"));
        public IWebElement BuyMoreButton => _driver.FindElement(By.LinkText("Buy more »"));
        public IWebElement PurchaseMessage => _driver.FindElement(By.ClassName("well"));

        public void VerifyPurchaseMessage(string message)
        {
            var text = PurchaseMessage.Text.Replace("\n", "").Trim();

            var finalText = PurchaseMessage.Text.Replace("\r\n", "");
            message.Should().BeEquivalentTo(finalText, string.Format("Purchase message is a mismatch. Expected: {0}, Actual:{1}",message, finalText));
        }
        public void ClickOnBuyMoreButton()
        {
            BuyMoreButton.Click();
        }
        public void VerifyBuyMoreButton()
        {
            BuyMoreButton.Text.Should().BeEquivalentTo("Buy more »", "Buy more button should be present in Sale Confirmed Page.");
        }
        public void VerifyBuyMoreButtonStatus(string status)
        {
            if (status.ToLower().Equals("enabled"))
            {
                BuyMoreButton.Enabled.Should().BeTrue("Buy more button should be enabled in Sale Confirmed Page.");
            }
            else if (status.ToLower().Equals("disabled"))
            {
                BuyMoreButton.Enabled.Should().BeFalse("Buy more button should be disabled in Sale Confirmed Page.");
            }
        }
    }
}
