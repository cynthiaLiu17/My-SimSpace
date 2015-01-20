/*Name: Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3:  
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Assignment3
{
    class PlanetShang
    {
        // The width of the planet
        public const int GRID_WIDTH = 20;
        // 2 Dimensional array to store the grid of planet
        private Facility[,] _facilities = new Facility[GRID_WIDTH, GRID_WIDTH];
        // Set the planet's begining money balance as $5,000,000
        public double Money = 5000000000;
        // Create the following public int variables TotalPower and TotalPollution to store 
        // the planet's total power and total pollution
        public int TotalPower = 0;
        public int TotalPollution = 0;
        // Create the public double variable to store the planets total population
        public double PlanetPopulation;

        public PlanetShang()
        {
            for (int rows = 0; rows < _facilities.GetLength(0); rows++)
            {
                for (int cols = 0; cols < _facilities.GetLength(1); cols++)
                {
                    _facilities[rows, cols] = new EmptyLand();
                }
            }
        }

        // This subprgram gets the image for the land square located at (x, y) 
        public Image GetImage(int x, int y)
        {
            return _facilities[x, y].Image; 
        }

        // MAKE FACILITIES START
        // This subprogram makes a new emergency service at the land square located at (x,y)
        public void MakeEmergencyService(int x, int y)
        {
            _facilities[x, y] = new EmergencyService();
        }

        // This subprogram makes a new school at the land square located at (x,y)
        public void MakeSchool(int x, int y)
        {
            _facilities[x, y] = new Schools();
        }

        // This subprogram makes a new medical at the land square located at (x,y)
        public void MakeMedical(int x, int y)
        {
            _facilities[x, y] = new Medical();
        }

        // This subprogram makes a new government at the land square located at (x,y)
        public void MakeGovernment(int x, int y)
        {
            _facilities[x, y] = new Government();
        }

        // This subprogram makes a new power plant at the land square located at (x,y)
        public void MakePowerPlant(int x, int y)
        {
            _facilities[x, y] = new PowerPlant();
        }
        // This subprogram makes a new affordable residence at the land square located at (x,y)
        public void MakeAffordableResidence(int x, int y)
        {
            _facilities[x, y] = new AffordableResidence(); 
        }

        // This subprogram makes a new comfortable residence at the land square located at (x,y)
        public void MakeComfortableResidence(int x, int y)
        {
            _facilities[x, y] = new ComfortableResidence();
        }

        // This subprogram makes a new luxury residence at the land square located at (x,y)
        public void MakeLuxuryResidence(int x, int y)
        {
            _facilities[x, y] = new LuxuryResidence();
        }
        // This subprogram makes a new factory at the land square located at (x,y)
        public void MakeFactory(int x, int y)
        {
            _facilities[x, y] = new Factories();
        }

        // This subprogram makes a new environmental facility at the land square located at (x,y)
        public void MakeEnvironmentalFacility(int x, int y)
        {
            _facilities[x, y] = new EnvironmentalFacilities();
        }

        // This subprogram makes a new store at the land square located at (x,y)
        public void MakeStore(int x, int y)
        {
            _facilities[x, y] = new Stores();
        }

        // This subprogram makes a new restaurant at the land square located at (x,y)
        public void MakeRestaurant(int x, int y)
        {
            _facilities[x, y] = new Restaurants();
        }

        // This subprogram makes a new office at the land square located at (x,y)
        public void MakeOffice(int x, int y)
        {
            _facilities[x, y] = new Offices();
        }
        // MAKE FACILITIES END

        // Create a public int variable Month to set the begining month as 0
        public int Month = 0;

        // This subprogram updates all totals in the game 
        public void UpdateTotals()
        {
            // Create a double variable to store the total tax revenue and set it as 0
            double totalTaxRevenue = 0;
            // Go through all the grid squares to update the total money, pollution and tax revenue
            for (int xIndex = 0; xIndex < _facilities.GetLength(0); xIndex++)
            {
                for (int yIndex = 0; yIndex < _facilities.GetLength(1); yIndex++)
                {
                    // Create a temporary facility to store the facility stored in the current 
                    // grid square
                    Facility tempFacility = this._facilities[xIndex, yIndex];
                    // If the current grid square is not empty, do the following
                    if (tempFacility != null)
                    {
                        // Update the planet's money by subtracting the maintence cost and
                        // adding the tax revenue of the facility in the current grid square
                        Money = Money - tempFacility.MaintenanceCost + tempFacility.TaxRevenue;
                        // Update the planet's tax revenue by adding the tax revenue of the facility in 
                        // the current grid square
                        totalTaxRevenue += tempFacility.TaxRevenue;
                        // Update the planet's pollution by adding the polltion of the facility in 
                        // the current grid square
                        TotalPollution += tempFacility.Pollution;
                        // Update the planet's power by adding the power of the facility in 
                        // the current grid square
                        TotalPower += tempFacility.Power;
                    }
                }
            }
            //If the planet doesn't have any power, subtract total tax revenue from the planet's money 
            if (TotalPower <= 0)
            {
                Money -= totalTaxRevenue;
            }
        }

        //This subprogram updates the residential population of the planet
        public void UpdateResidentialPopulation()
        {
            // Set the population of the planet back to 0
            PlanetPopulation = 0;
            // Go through all the grid squares to update the total residential population
            for (int xIndex = 0; xIndex < _facilities.GetLength(0); xIndex++)
            {
                for (int yIndex = 0; yIndex < _facilities.GetLength(1); yIndex++)
                {
                    // Create a temporary facility to store the facility stored in the current 
                    // grid square
                    Facility tempFacility = this._facilities[xIndex, yIndex];
                    // If the current grid square is not empty, do the following
                    if (tempFacility != null)
                    {
                        // If the grid square contains a residential facility, do the following
                        if (tempFacility is Residential)
                        {
                            // 
                            Residential tempResidence = (Residential)tempFacility;
                            // If the residence facility's population is not at its maximum population,
                            // increase the current population by 10% of its maximum population 
                            if (tempResidence.CurrentPopulation != tempResidence.MaximumPopulation)
                            {
                                tempResidence.CurrentPopulation += (int)(0.1 * tempResidence.MaximumPopulation);
                            }
                            PlanetPopulation += tempResidence.CurrentPopulation;
                        }
                    }
                }
            }
        }

        // This function subprogram calculates the user's score
        public double CalculateScore()
        {
            // Create a double score to store the score and set it to 0
            double score = 0;
            // Go through all the grid squares to update the total residential population 
            for (int xIndex = 0; xIndex < _facilities.GetLength(0); xIndex++)
            {
                for (int yIndex = 0; yIndex < _facilities.GetLength(1); yIndex++)
                {
                    // If the current grid square is not empty, do the following
                    Facility tempFacility = this._facilities[xIndex, yIndex];
                    // If the current grid square is not empty, do the following
                    if (tempFacility != null)
                    {
                        // If the grid square contains a residential facility, do the following
                        if (tempFacility is Residential)
                        {
                            //
                            Residential tempResidentialFacility = (Residential)tempFacility;
                            // Calculate the new score by multiplying the current grid square's
                            // happy population by 3 and add the content population 
                            score += 3 * tempResidentialFacility.HappyPopulation + tempResidentialFacility.ContentPopulation;
                        }
                        // Subtract the pollution level from the score
                        score -= tempFacility.Pollution;
                    }
                }
            }
            //Return the score
            return score;
        }
    }
}
