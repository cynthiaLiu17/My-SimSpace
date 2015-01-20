/*Name: Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:  
 * This is a child of the Facility class
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    abstract class Residential : Facility
    {
        // Store maximum population
        protected double _maximumPopulation;
        public double MaximumPopulation
        {
            // Return _maximumPopulation
            get
            {
                return _maximumPopulation;
            }
            // Set _maximumPopultion as value 
            set
            {
                _maximumPopulation = value;
            }
        }

        // Store content population 
        protected int _contentPopulation;
        public int ContentPopulation
        {
            // Return _contentPopulation
            get
            {
                return _contentPopulation;
            }
            // Set _contentPopulation as value
            set
            {
                _contentPopulation = value;
            }
        }
        
        //Store happy population
        protected int _happyPopulation;
        public int HappyPopulation
        {
            // Return _happyPopulation
            get
            {
                return _happyPopulation;
            }
            // Set _happyPopulation as value
            set
            {
                _happyPopulation = value;
            }
        }

        // Store current population
        protected int _currentPopulation;
        public int CurrentPopulation
        {
            // Return _currentPopulation
            get
            {
                return _currentPopulation;
            }
            // Set _currentPopulation as value
            set
            {
                _currentPopulation = value;
            }
        }

        // Calculate tax revenue
        public virtual double GetTaxRevenue()
        {
            return (_currentPopulation / 1000) * 1500000;
        }

        // Residential class consructor
        protected Residential(double buildCost, int pollution, double maintenanceCost, int power, double taxRevenue, double maximumPopulation) 
            : base(buildCost, maintenanceCost, pollution, power, taxRevenue)
        {
            // Set maximum population 
            _maximumPopulation = maximumPopulation;
            // Set tax revenue 
            _taxRevenue = GetTaxRevenue();
        }

        // Calculate content population
        public abstract int GetContentPopulation(double contentPopulationRatio, int currentPopulation)
        {
            //Return the content population 
            return (int)(contentPopulationRatio * currentPopulation);
        }

        // Calculate happy population 
        public abstract int GetHappyPopulation(double happyPopulationRatio, double currentPopulation)
        {
            // Return the happy population
            return (int)(happyPopulationRatio * currentPopulation);
        }
    }
}
