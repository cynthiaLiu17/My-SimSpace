/* Name: Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:
 * This is a child of the Essential Services class
 * It costs $500,000,000 to build
 * It generates no tax revenue
 * It costs $5,000,000 to maintain each month
 * It consumes 15 units of power 
 * It creates no pollution
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Schools : EssentialServices
    {
        // Constructor for schools 
        public Schools() 
            : base(500000000, 5000000, -15)
        {
            // Set image 
            _image = Properties.Resources.school;
        }
    }
}
