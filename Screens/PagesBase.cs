using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Screens
{
    public class PagesBase
    {
        public static IWebDriver _driver { get; private set; }

        public static void InitStartApp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ensekautomationcandidatetest.azurewebsites.net/");

            driver.Manage().Window.Maximize();
            var currentWindow = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(currentWindow);
            _driver = driver;
        }

        public static void SelectItems(IWebElement element, string text, bool partialMatch)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text, partialMatch);
        }

        public static string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("ddd dd MMM");
        }

        public static string FormatTime(DateTime dateTime)
        {
            return dateTime.ToString("HH:mm");
        }

        public static void MoveTo(IWebElement element)
        {
            OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(_driver);
            actions.MoveToElement(element).Perform();
        }

        public static void CloseApplication()
        {
            _driver.Close();
        }

    }
}
