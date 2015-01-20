/* December , 2013
* This is a child of the Industrial class
* It costs $50,000,000,000 to build
* It generates $5,000,000 tax revenue each month
* It costs $500,000 to maintain each month
* It consumes 10 units of power each month
* It creates 20,000 units of pollution
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    // Factory Constructor 
    class Factories : Industrial
    {
        // Factory constructor
        public Factories() 
            : base(50000000, 500000, 5000000, -50, 20000)
        {
            //Set image 
            _image = Properties.Resources.factories;
        }
    }
}
