﻿/* Name: Cynthia
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
    class Industrial : Facility
    {
        // Constructor for industrial class
        protected Industrial(double buildCost, double maintenanceCost, double taxRevenue, int power, int pollution)
            : base(buildCost, maintenanceCost, pollution, power, taxRevenue)
        {
            // Do nothing 
        }
    }
}
