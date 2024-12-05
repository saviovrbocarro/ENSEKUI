using ENSEKUITests.Model;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Screens
{
    public class BuyEnergy:PagesBase
    {
        public BuyEnergyDetailsExpectations _buyEnergyDetailsExpectations;

        public IWebElement HomePageTitle => _driver.FindElement(By.CssSelector("div[class='container body-content']")).FindElement(By.TagName("h2"));
        public IWebElement ResetButton => _driver.FindElement(By.Name("Reset"));
        public IWebElement table => _driver.FindElement(By.ClassName("table"));

        public void VerifyListOfContentsFromBuyDetailsTable(IEnumerable<BuyEnergyDetails> expectedTableData)
        {
            var actualTableData = GetEnergyTypeDetailsBasedOnColumn();

            for (int i = 0; i < actualTableData.Count; i++)
            {
                var enumerator = expectedTableData.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    actualTableData[i].EnergyType.Should().BeEquivalentTo(enumerator.Current.EnergyType, "Energy Type mismatch.");

                    actualTableData[i].Price.Should().BeEquivalentTo(enumerator.Current.Price, "Price mismatch");
                    actualTableData[i].QuantityOfUnitsAvailable.Should().BeGreaterThanOrEqualTo(enumerator.Current.QuantityOfUnitsAvailable, "Quantity of units available mismatch");
                    actualTableData[i].NumberOfUnitsRequired.Should().BeEquivalentTo(enumerator.Current.NumberOfUnitsRequired, "Number of units required mismatch");
                    i++;
                }
            }
        }

        public List<BuyEnergyDetailsExpectations> GetEnergyTypeDetailsBasedOnColumn()
        {
            var tableData = new List<BuyEnergyDetailsExpectations>();
            int energyTypeColIndex = GetColIndexBasedonColName("Energy Type");
            int priceColIndex = GetColIndexBasedonColName("Price");
            int quantityOfUnitsAvailColIndex = GetColIndexBasedonColName("Quanity of Units Available");
            int noOfUnitsRequiredColIndex = GetColIndexBasedonColName("Number of Units Required");

            var tableRows = table.FindElements(By.XPath("./tbody/tr"));

            for (int i = 0; i < tableRows.Count; i++)
            {
                _buyEnergyDetailsExpectations = new BuyEnergyDetailsExpectations();
                _buyEnergyDetailsExpectations.EnergyType = tableRows[i].FindElements(By.XPath("./td"))[energyTypeColIndex].Text;
                _buyEnergyDetailsExpectations.Price = tableRows[i].FindElements(By.XPath("./td"))[priceColIndex].Text;
                _buyEnergyDetailsExpectations.QuantityOfUnitsAvailable = int.Parse(tableRows[i].FindElements(By.XPath("./td"))[quantityOfUnitsAvailColIndex].Text);
                try
                {
                    _buyEnergyDetailsExpectations.NumberOfUnitsRequired =
                        tableRows[i].FindElements(By.XPath("./td"))[noOfUnitsRequiredColIndex].FindElement(By.TagName("input")).GetAttribute("value").ToString();
                }
                catch(NoSuchElementException ex)
                {
                    _buyEnergyDetailsExpectations.NumberOfUnitsRequired = tableRows[i].FindElements(By.XPath("./td"))[noOfUnitsRequiredColIndex].Text;
                }
                tableData.Add(_buyEnergyDetailsExpectations);
            }

            return tableData;
        }

        public void EnterNoOfUnitsRequiredBasedOnEnergyType(string expectedEnergyType, int enternoOfUnits)
        {
            int energyTypeColIndex = GetColIndexBasedonColName("Energy Type");
            int noOfUnitsRequiredColIndex = GetColIndexBasedonColName("Number of Units Required");
            string energyType = String.Empty;

            var tableRows = table.FindElements(By.XPath("./tbody/tr"));

            for (int i = 0; i < tableRows.Count; i++)
            {
                energyType = tableRows[i].FindElements(By.XPath("./td"))[energyTypeColIndex].Text;

                if (energyType.ToLower().Equals(expectedEnergyType.ToLower()))
                {
                    tableRows[i].FindElements(By.XPath("./td"))[noOfUnitsRequiredColIndex].FindElement(By.TagName("input")).Clear();
                    tableRows[i].FindElements(By.XPath("./td"))[noOfUnitsRequiredColIndex].FindElement(By.TagName("input")).SendKeys(enternoOfUnits.ToString());
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public void ClickOnBuyBasedOnEnergyType(string expectedEnergyType)
        {
            int energyTypeColIndex = GetColIndexBasedonColName("Energy Type");
            int buyButtonColIndex = GetColIndexBasedonColName("");
            string energyType = String.Empty;

            var tableRows = table.FindElements(By.XPath("./tbody/tr"));

            for (int i = 0; i < tableRows.Count; i++)
            {
                energyType = tableRows[i].FindElements(By.XPath("./td"))[energyTypeColIndex].Text;

                if (energyType.ToLower().Equals(expectedEnergyType.ToLower()))
                {
                    tableRows[i].FindElements(By.XPath("./td"))[buyButtonColIndex].FindElement(By.TagName("input")).Click();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        public List<string> GetEnergyTypeDetailsListBasedOnColumn(string colName)
        {
            var detailList = new List<string>();
            int colIndex = GetColIndexBasedonColName(colName);
            var tableRows = table.FindElements(By.XPath("./tbody/tr"));

            for (int i = 0; i < tableRows.Count; i++)
            {
                var t = tableRows[i].FindElements(By.XPath("./td"))[colIndex].Text;
                detailList.Add(t);
            }

            return detailList;
        }

        public int GetColIndexBasedonColName(string colName)
        {
            int index = 0;
            var columns = table.FindElements(By.XPath("./thead/tr/th"));

            for (int i = 0; i < columns.Count; i++)
            {
                if (columns[i].Text.Equals(colName))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void VerifyBuyButtonIsPresentBasedOnEnergyType(string expectedEnergyType)
        {
            int energyTypeColIndex = GetColIndexBasedonColName("Energy Type");
            int buyButtonColIndex = GetColIndexBasedonColName("");
            string energyType = String.Empty;
            IWebElement buyButtonDisplayed = null;
            bool buyButtonIsNotDisplayed = false;

            var tableRows = table.FindElements(By.XPath("./tbody/tr"));

            for (int i = 0; i < tableRows.Count; i++)
            {
                energyType = tableRows[i].FindElements(By.XPath("./td"))[energyTypeColIndex].Text;

                try
                {
                    if (energyType.ToLower().Equals(expectedEnergyType.ToLower()))
                    {
                        buyButtonDisplayed = tableRows[i].FindElements(By.XPath("./td"))[buyButtonColIndex].FindElement(By.TagName("input"));
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (NoSuchElementException ex)
                {
                    buyButtonIsNotDisplayed = true;
                    break;
                }
            }
            buyButtonDisplayed.Should().BeNull("Buy button expected not to be displayed");
            buyButtonIsNotDisplayed.Should().BeTrue("Buy button expected not to be displayed");
        }
    }
}
