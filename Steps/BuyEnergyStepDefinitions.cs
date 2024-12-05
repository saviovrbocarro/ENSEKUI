using ENSEKUITests.Actions;
using ENSEKUITests.Actors;
using ENSEKUITests.Model;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace ENSEKUITests.Steps
{
    [Binding]
    public sealed class BuyEnergyStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly Actor<AppElements> actor;

        public BuyEnergyStepDefinitions(Actor<AppElements> actor, ScenarioContext scenarioContext)
        {
            this.actor = actor;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I Navigate to ENSEK website")]
        public void GivenINavigateToENSEKWebsite()
        {
            this.actor.AttemptsTo.NavigateToSite();
        }


        [Then(@"The user should be in ENSEK homepage")]
        public void ThenTheUserShouldBeInENSEKHomepage()
        {
            this.actor.ExpectsTo.SeeHomepage("ENSEK Energy Corp.");
        }

        [When(@"I click on Buy Energy button")]
        public void WhenIClickOnBuyEnergyButton()
        {
            this.actor.AttemptsTo.ClickOnBuyEnergy();
        }

        [When(@"I click on Reset button")]
        public void WhenIClickOnResetButton()
        {
            this.actor.AttemptsTo.ClickOnResetButton();
        }

        [Then(@"the user should be navigated to (.*) page")]
        public void ThenTheUserShouldBeNavigatedToPage(string page)
        {
            this.actor.ExpectsTo.SeeBuyEnergyPage(page);
        }

        [Then(@"the user should see the list of energy type with details")]
        public void ThenTheUserShouldSeeTheListOfEnergyTypeWithDetails(IEnumerable<BuyEnergyDetails> _buyEnergyDetails)
        {
            this.actor.ExpectsTo.ValidateTableContents(_buyEnergyDetails);
        }

        [When(@"I enter (.*) units required for (.*) energy type")]
        public void WhenIEnterUnitsRequiredForEnergyType(int units ,string energyType)
        {
            this.actor.AttemptsTo.EnterNoOfUnitsRequiredBasedOnEnergyType(energyType, units);
        }

        [When(@"I click on Buy button for (.*) energy type")]
        public void WhenIClickOnBuyButtonForEnergyType(string energyType)
        {
            this.actor.AttemptsTo.ClickOnBuyBasedOnEnergyType(energyType);
        }

        [Then(@"the User should see (.*) With message (.*)")]
        public void ThenTheUserShouldSeeWithMessage(string confirmationMessage, string message)
        {
            this.actor.ExpectsTo.SeeSaleConfirmedPage(confirmationMessage);
            this.actor.ExpectsTo.SeePurchaseText(message);
        }

        [Then(@"the user should see Buy more button")]
        public void ThenTheUserShouldSeeBuyMoreButton()
        {
            this.actor.ExpectsTo.SeeBuyMoreButton();
        }

        [Then(@"The user should see buy button (.*)")]
        public void ThenTheUserShouldSeeBuyButton(string buttonStatus)
        {
            this.actor.ExpectsTo.SeeBuyMoreButtonStatus(buttonStatus);
        }

        [When(@"the user clicks on Buy more button")]
        public void WhenTheUserClicksOnBuyMoreButton()
        {
            this.actor.AttemptsTo.ClickOnBuyMore();
        }

        [Then(@"The user should not see Buy button for (.*) energy type")]
        public void ThenTheUserShouldNotSeeBuyButtonForEnergyType(string energyType)
        {
            this.actor.ExpectsTo.SeeBuyButtonPresentBasedOnEnergyType(energyType);
        }
    }
}
