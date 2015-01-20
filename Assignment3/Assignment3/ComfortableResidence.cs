/* December , 2013
* This is a child of the Residential class.
* It costs $500,000,000 to build
* It generates $100,000 per 1,000 people living there per month
* 25% of people are happy and 75% are content
* It costs $1,000,000 to maintain each month 
* It also houses up to 15,000 people
* It consumes 50 units of power
* It produces 2,000 units of pollution when it is full 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class ComfortableResidence : Residential
    {
        // Comfortable Residence constructor 
        public ComfortableResidence() 
            : base(500000000, 0, 1000000, -50, 0, 15000)
        {
            // Set image 
            _image = Properties.Resources.comfortableHouse;
            // Find values for content population and happy population
            _contentPopulation = GetContentPopulation(0.75, _currentPopulation);
            _happyPopulation = GetHappyPopulation(0.25, _currentPopulation);
            if (_currentPopulation != 0)
            {
                _pollution = (int)((_currentPopulation / _maximumPopulation) * 2000);
            }
        }

        public override double GetTaxRevenue()
        {
            return ((_currentPopulation / 1000) * 100000);
        }
    }
}
