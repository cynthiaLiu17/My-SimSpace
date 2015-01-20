/* December , 2013
* This is a child of the Industrial class
* It costs $200,000,000,000 to build
* It generates no tax revenue
* It costs $3,000,000 to maintain each month
* It consumes 75 units of power each month
* It eliminates 20,000 units of pollution
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class EnvironmentalFacilities : Industrial
    {
        // Constructor for Environmental Facilities 
        public EnvironmentalFacilities()
            : base(200000000, 3000000, 0, -75, -20000)
        {
            // Set image
            _image = Properties.Resources.environmentalFacility;
        }
    }
}
