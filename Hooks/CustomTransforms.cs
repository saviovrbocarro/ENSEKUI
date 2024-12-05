using ENSEKUITests.Model;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ENSEKUITests.Hooks
{
    [Binding]
    public class CustomTransforms
    {
        [StepArgumentTransformation()]
        public IEnumerable<BuyEnergyDetails> BuyEnergyDetailsTransform(Table table)
        {
            return table.CreateSet<BuyEnergyDetails>();
        }
    }
}
