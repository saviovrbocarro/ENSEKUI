using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEKUITests.Model
{
    public class BuyEnergyDetails
    {
        public string EnergyType { get; set; }
        public string Price { get; set; }
        public int QuantityOfUnitsAvailable { get; set; }
        public string NumberOfUnitsRequired { get; set; }
    }
}
