using ENSEKUITests.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Actors
{
    public class AppElements
    {
        public AppElements()
        {
            this.HomePage = new HomePage();
            this.BuyEnergy = new BuyEnergy();
            this.SaleConfirmedPage = new SaleConfirmedPage();
        }

        public HomePage HomePage { get; }
        public BuyEnergy BuyEnergy { get; }
        public SaleConfirmedPage SaleConfirmedPage { get; }
    }
}
