/* December , 2013
* This is a child of the Essential Services class
* It costs $10,000,000,000 to build
* It generates no tax revenue
* It costs $1,000,000 to maintain each month
* It consumes 10 units of power 
* It creates no pollution
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Government : EssentialServices
    {
        // Government constructor
        public Government() 
            : base(10000000, 1000000, -10)
        {
            // Set image 
            _image = Properties.Resources.Government;
        }
    }
}
