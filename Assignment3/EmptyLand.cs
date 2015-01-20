/*Name: Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:
 * This is a child of the Facility class
 * It costs no money to build
 * It generates no tax revenue
 * It costs no money to maintain each month
 * It consumes 0 units of power
 * It produces 0 units of pollution
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class EmptyLand : Facility
    {
        // Constructor for empty land
        public EmptyLand()
            : base(0, 0, 0, 0, 0)
        {
            // Set image 
            _image = Properties.Resources.emptyland;
        }
    }
}
