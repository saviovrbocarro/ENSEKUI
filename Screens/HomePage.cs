using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Screens
{
    public class HomePage: PagesBase
    {
        public IWebElement HomePageTitle => _driver.FindElement(By.ClassName("jumbotron")).FindElement(By.TagName("h1"));
        public IWebElement BuyEnergyButton => _driver.FindElement(By.LinkText("Buy energy »"));
        WebDriverWait wait = null;

        public void ClickOnBuyEnergy()
        {
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(d => BuyEnergyButton.Displayed);

            BuyEnergyButton.Click();
        }
    }
}
