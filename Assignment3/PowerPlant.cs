/* Name: Wendy and Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:
 * This is a child of the Essential Services class
 * It costs $500,000,000,000 to build
 * It generates no tax revenue
 * It costs $2,000,000 to maintain each month
 * It produces 100 units of power 
 * It creates no pollution
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class PowerPlant : EssentialServices
    {
        // Constructor for power plant 
        public PowerPlant() 
            : base(500000000, 2000000, 100)
        {
            // Set image 
            _image = Properties.Resources.powerPlant;
        }
    }
}
