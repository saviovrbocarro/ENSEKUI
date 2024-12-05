using ENSEKUITests.Actors;
using ENSEKUITests.Screens;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Actions
{
    public static class HomepageInteractions
    {
        public static void NavigateToSite(this IActorInteractionsContext<AppElements> ctx)
        {
            PagesBase.InitStartApp();
        }

        public static void ClickOnBuyEnergy(this IActorInteractionsContext<AppElements> ctx)
        {
            ctx.Elements.HomePage.ClickOnBuyEnergy();
        }
    }
}
