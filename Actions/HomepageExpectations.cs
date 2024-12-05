using ENSEKUITests.Actors;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ENSEKUITests.Actions
{
    public static class HomepageExpectations
    {
        public static void SeeHomepage(this IActorExpectationsContext<AppElements> ctx, string messageText)
        {
            Thread.Sleep(2000);
            ctx.Elements.HomePage.HomePageTitle.Text.Should().Contain(messageText, "Homepage should be displayed");
        }

    }
}
