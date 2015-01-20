/* December , 2013
* This is a child of the Commercial class
* It costs $2,000,000 to build
* It generates $200,000 tax revenue each month
* It costs $50,000 to maintain each month
* It consumes 5 units of power each month
* It creates 500 units of pollution
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Stores : Commercial
    {
        // Constructor for store 
        public Stores() 
            : base(2000000, 50000, 200000, -5, 500)
        {
            // S
            _buildCost = 2000000;
            _maintenanceCost = 50000;
            _taxRevenue = 200000;
            _pollution = 500;
            _power = 5;
            _image = Properties.Resources.stores;
        }
    }
}
