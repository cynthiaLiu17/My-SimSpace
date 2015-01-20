
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Industrial : Facility
    {
        // Industrial class constructor
        protected Industrial(double buildCost, double maintenanceCost, double taxRevenue, int power, int pollution)
            : base(buildCost, maintenanceCost, pollution, power, taxRevenue)
        {
            // Do nothing 
        }
    }
}
