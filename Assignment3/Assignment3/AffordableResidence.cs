 /* December , 2013
 * This is a child of the Residential class.
 * It costs $50,000,000 to build
 * It generates $10,000 per 1,000 people living there per month
 * 10% of people are happy and 90% are content
 * It costs $800,000 to maintain each month
 * It also houses up to 25,000 people
 * It consumes 25 units of power
 * It produces 1,000 units of pollution when it is full 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class AffordableResidence : Residential
    {
        // Constructor for affordable residence 
        public AffordableResidence() 
            : base(50000000, 0, 800000, -25, 0, 25000)
        {
            // Set image
            _image = Properties.Resources.affordableHomes;
            // Find values for content population and happy population
            _contentPopulation = GetContentPopulation(0.9, _currentPopulation);
            _happyPopulation = GetHappyPopulation(0.1, _currentPopulation);
            if (_currentPopulation != 0)
            {
                _pollution = (int)((_currentPopulation / _maximumPopulation) * 1000);
            }
        }

        public override double GetTaxRevenue()
        {
            return ((_currentPopulation / 1000) * 10000);
        }
    }
}
