using ENSEKUITests.Actors;
using ENSEKUITests.Model;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ENSEKUITests.Actions
{
    public static class BuyEnergyExpectations
    {
        public static void SeeBuyEnergyPage(this IActorExpectationsContext<AppElements> ctx, string messageText)
        {
            Thread.Sleep(2000);
            ctx.Elements.BuyEnergy.HomePageTitle.Text.Should().Contain(messageText, "Homepage should be displayed");
        }

        public static void ValidateTableContents(this IActorExpectationsContext<AppElements> ctx, IEnumerable<BuyEnergyDetails> _buyEnergyDetails)
        {
            ctx.Elements.BuyEnergy.VerifyListOfContentsFromBuyDetailsTable(_buyEnergyDetails);
        }
        public static void SeeSaleConfirmedPage(this IActorExpectationsContext<AppElements> ctx, string messageText)
        {
            Thread.Sleep(2000);
            ctx.Elements.SaleConfirmedPage.SaleConfirmedTitle.Text.Should().Contain(messageText, "Sale Confirmed! should be displayed");
        }
        public static void SeePurchaseText(this IActorExpectationsContext<AppElements> ctx, string messageText)
        {
            Thread.Sleep(2000);
            ctx.Elements.SaleConfirmedPage.VerifyPurchaseMessage(messageText);
        }
        public static void SeeBuyMoreButton(this IActorExpectationsContext<AppElements> ctx)
        {
            Thread.Sleep(2000);
            ctx.Elements.SaleConfirmedPage.VerifyBuyMoreButton();
        }
        public static void SeeBuyMoreButtonStatus(this IActorExpectationsContext<AppElements> ctx, string status)
        {
            Thread.Sleep(2000);
            ctx.Elements.SaleConfirmedPage.VerifyBuyMoreButtonStatus(status);
        }
        public static void SeeBuyButtonPresentBasedOnEnergyType(this IActorExpectationsContext<AppElements> ctx, string energyType)
        {
            Thread.Sleep(2000);
            ctx.Elements.BuyEnergy.VerifyBuyButtonIsPresentBasedOnEnergyType(energyType);
        }

    }
}
