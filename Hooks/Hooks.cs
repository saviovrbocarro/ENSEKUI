using BoDi;
using ENSEKUITests.Actors;
using ENSEKUITests.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ENSEKUITests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly ScenarioContext _scenarioContext;

        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
            objectContainer.RegisterInstanceAs(new AppElements());
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //Service.Instance.ValueRetrievers.Register(new DateTimeValueRetriever());
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
        }

        [AfterScenario]
        public static void CleanUp()
        {
            PagesBase.CloseApplication();
        }
    }
}
