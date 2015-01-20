using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Assignment3
{
    class Facility
    {
        // Store image of facilities
        protected Image _image;
        public Image Image
        {
            // Return the image
            get
            {
                return _image;
            }
        }
        // Store image of build cost 
        protected double _buildCost;
        public double BuildCost
        {
            // Return the image
            get
            {
                return _buildCost;
            }
            // Set _buildCost as value
            protected set
            {
                _buildCost = value;
            }
        }

        // Store maintenance cost 
        protected double _maintenanceCost;
        public double MaintenanceCost
        {
            //Return the image
            get
            {
                return _maintenanceCost;
            }
            // Set _maintanceCost as value
            protected set
            {
                _maintenanceCost = value;
            }
        }

        // Store tax revenue
        protected double _taxRevenue;
        public virtual double TaxRevenue
        {
            // Return the image
            get
            {
                return _taxRevenue;
            }
            // Set _taxRevenue as value
            set
            {
                _taxRevenue = value;
            }
        }

        // Store pollution
        protected int _pollution;
        public virtual int Pollution
        {
            // Return the image
            get
            {
                return _pollution;
            }
            // Set _pollution as value
            protected set
            {
                _pollution = value;
            }
        } 

        // Store power
        protected int _power;
        public int Power
        {
            //Return the image
            get
            {
                return _power;
            }
            //Set _power as value
            protected set
            {
                _power = value;
            }
        }

        // Constructor for facility 
        protected Facility(double buildCost, double maintenanceCost, int pollution, int power, double taxRevenue)
        {
            // Set the following values 
            _buildCost = buildCost;
            _maintenanceCost = maintenanceCost;
            _pollution = pollution;
            _power = power;
            _taxRevenue = taxRevenue;
        }
    }
}
