using ENSEKUITests.Actors;
using ENSEKUITests.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Actions
{
    public static class BuyEnergyInteractions
    {
        public static void ClickOnResetButton(this IActorInteractionsContext<AppElements> ctx)
        {
            ctx.Elements.BuyEnergy.ResetButton.Click();
        }
        public static void ClickOnBuyBasedOnEnergyType(this IActorInteractionsContext<AppElements> ctx, string expectedEnergyType)
        {
            ctx.Elements.BuyEnergy.ClickOnBuyBasedOnEnergyType(expectedEnergyType);
        }
        public static void EnterNoOfUnitsRequiredBasedOnEnergyType(this IActorInteractionsContext<AppElements> ctx, string expectedEnergyType, int enternoOfUnits)
        {
            ctx.Elements.BuyEnergy.EnterNoOfUnitsRequiredBasedOnEnergyType(expectedEnergyType, enternoOfUnits);
        }
        public static void ClickOnBuyMore(this IActorInteractionsContext<AppElements> ctx)
        {
            ctx.Elements.SaleConfirmedPage.ClickOnBuyMoreButton();
        }

    }
}
