using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    class Factory
    {
        public static AffordableResidence MakeAffordableResidence()
        {
            AffordableResidence tempAffordableResidence = new AffordableResidence();
            return tempAffordableResidence;
        }
        public static ComfortableResidence MakeComfortableResidence()
        {
            ComfortableResidence tempComfortableResidence = new ComfortableResidence();
            return tempComfortableResidence;
        }
        public static LuxuryResidence MakeLuxuryResidence()
        {
            LuxuryResidence tempLuxuryResidence = new LuxuryResidence();
            return tempLuxuryResidence;
        }
        public static Factories MakeFactory()
        {
            Factories tempFactory = new Factories();
            return tempFactory;
        }
        public static EnvironmentalFacilities makeEnvironmentalFacility()
        {
            EnvironmentalFacilities tempEnvironmentalFacility = new EnvironmentalFacilities();
            return tempEnvironmentalFacility;
        }
        public static Restaurants makeRestaurant()
        {
            Restaurants tempRestaurant = new Restaurants();
            return tempRestaurant;
        }
        public static Offices makeOffice()
        {
            Offices tempOffice = new Offices();
            return tempOffice;
        }
        public static Stores makeStore()
        {
            Stores tempStore = new Stores();
            return tempStore;
        }
    }
}
