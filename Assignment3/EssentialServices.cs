/* Name: Wendy and Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:  
 * This is a child of the Facility class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class EssentialServices : Facility
    {
        // Constructor for essential services
        protected EssentialServices(double buildCost, double maintenanceCost, int power)
            : base(buildCost, maintenanceCost, 0, power, 0)
        {
            // Do nothing
        }
    }
}
