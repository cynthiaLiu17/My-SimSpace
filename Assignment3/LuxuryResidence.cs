/* Name: Wendy and Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3: 
 * This is a child of the Residential class.
 * It costs $1,000,000,000 to build
 * It generates $1,500,000 per 1,000 people living there per month
 * 50% of people are happy and 50% are content
 * It costs $1,000,000 to maintain each month 
 * It also houses up to 10,000 people
 * It consumes 100 units of power
 * It produces 5,000 units of pollution when it is full  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class LuxuryResidence : Residential
    {
        // Constructor for luxury residence 
        public LuxuryResidence() 
            : base(1000000000, 0, 1000000, -100, 0, 10000)
        {
            // Set image 
            _image = Properties.Resources.luxuryhome;
            // Find values for content population and happy population
            _contentPopulation = GetContentPopulation(0.5, _currentPopulation);
            _happyPopulation = GetHappyPopulation(0.5, _currentPopulation);
            // If the current population does not equal 0, calculate pollution
            if (_currentPopulation != 0)
            {
                _pollution = (int)((_currentPopulation / _maximumPopulation) * 5000);
            }
        }
    }
}
