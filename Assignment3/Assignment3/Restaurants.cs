/* December , 2013
* This is a child of the Commercial class
* It costs $250,000 to build
* It generates $10,000 tax revenue each month
* It costs $5,000 to maintain each month
* It consumes 5 units of power each month
* It creates 300 units of pollution
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Restaurants : Commercial
    {
        // Restaurant constructor 
        public Restaurants() 
            : base(250000, 5000, 1000, -5, 300)
        {
            // Set image
            _image = Properties.Resources.restaurants;
        }
    }
}
