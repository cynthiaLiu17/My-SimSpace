/* December , 2013
* This is a child of the Essential Services class
* It costs $1,000,000,000 to build
* It generates no tax revenue
* It costs $15,000,000 to maintain each month
* It consumes 20 units of power 
* It creates no pollution
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Medical : EssentialServices
    {
        // Medical constructor 
        public Medical() 
            : base(100000000, 1500000, -20)
        {
            // Set image 
            _image = Properties.Resources.medical;
        }
    }
}