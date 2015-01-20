/* Name: Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:
 * This is a child of the Commercial class
 * It costs $3,000,000 to build
 * It generates $20,000 tax revenue each month
 * It costs $10,000 to maintain each month
 * It consumes 15 units of power each month
 * It creates 800 units of pollution
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Offices : Commercial
    {
        // Constructor for offices
        public Offices() 
            : base(3000000, 10000, 20000, -15, 800)
        {
            // Set image 
            _image = Properties.Resources.offices;
        }
    }
}
