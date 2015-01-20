/*Name: Wendy and Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:  
 * This is a child of the Essential Services class
 * It costs $100,000,000 to build
 * It generates no tax revenue
 * It costs $50,000 to maintain each month
 * It consumes 5 units of power 
 * It creates no pollution
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class EmergencyService : EssentialServices
    {
        // Constructor for emergency service 
        public EmergencyService() 
            : base(100000000, 100000000, -20)
        {
            // Set image 
            _image = Properties.Resources.emergencyServices;
        }
    }
}
