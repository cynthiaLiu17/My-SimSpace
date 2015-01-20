using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class EssentialServices : Facility
    {
        // Essential services class constructor
        protected EssentialServices(double buildCost, double maintenanceCost, int power)
            : base(buildCost, maintenanceCost, 0, power, 0)
        {
            // Do nothing
        }
    }
}
