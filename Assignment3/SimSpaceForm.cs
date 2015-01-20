/* Name: Cynthia
 * Date: January 7, 2014
 * Purpose: Assignment 3: 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class SimSpaceForm : Form
    {
        // The width of the planet
        public const int FACILITY_WIDTH = 40;

        // Create 2D arrays to draw the shapes on 
        Rectangle[,] _grid = new Rectangle[PlanetShang.GRID_WIDTH, PlanetShang.GRID_WIDTH];
        Rectangle[] _facilityBar = new Rectangle[13]; 
        // Pen used to draw the outlines of the grid squares 
        Pen blackPen = new Pen(Color.Black); 
        // The model to store all of the island's information 
        PlanetShang _thePlanet = new PlanetShang();
        // Create the size of the rectangle 
        Size rectangleSize = new Size(FACILITY_WIDTH, FACILITY_WIDTH);
        // Value of the buildingBeingMadeIndex variable if no building is being made 
        const int FACILITY_NOT_BEING_MADE = -1;
        // Stores the indexs of the building being made, if one is being made 
        int facilityBeingMadeIndex = FACILITY_NOT_BEING_MADE;

        // Stores constants of various facilities
        const int EMERGENCY_SERVICE = 0;
        const int SCHOOLS = 1;
        const int MEDICAL = 2;
        const int GOVERNMENT = 3;
        const int POWER_PLANT = 4;
        const int LUXURY_HOME = 5;
        const int COMFORTABLE_HOME = 6;
        const int AFFORDABLE_HOME = 7;
        const int FACTORY = 8;
        const int ENVIRONMENTAL_FACILITY = 9;
        const int STORE = 10;
        const int RESTAURANT = 11;
        const int OFFICES = 12;

        public SimSpaceForm()
        {
            InitializeComponent();
            // Setup the drawing rectangles for the grid and building bar 
            SetupGrid();
            SetUpFacilityBar(); 
        }

        // Set up the rectangles that the user can click on to add facilities to the Form
        void SetUpFacilityBar()
        {
            for (int counter = 0; counter < _facilityBar.Length; counter++)
            {
                Point facilityLocation = new Point(counter * 40, FACILITY_WIDTH * (PlanetShang.GRID_WIDTH + 1));
                _facilityBar[counter] = new Rectangle(facilityLocation, rectangleSize);
            }
        }

        void SetupGrid()
        { 
            // Set up the widths of each rectangle in the gris 
            for (int cols = 0; cols < _grid.GetLength(0); cols++)
            {
                for (int rows = 0; rows < _grid.GetLength(1); rows++)
                {
                    // Create a Point for the left left corner of the rectangle 
                    Point rectangleLocation = new Point(cols * FACILITY_WIDTH, rows * FACILITY_WIDTH);
                    _grid[cols, rows] = new Rectangle(rectangleLocation, rectangleSize); 
                }
            }
        }

        // Draw the Facility Bar that allows users to drag and drop facilities onto the grid 
        void DrawFacilityBar(Graphics canvas)
        {
            canvas.DrawImage(Properties.Resources.emergencyServices, _facilityBar[EMERGENCY_SERVICE]);
            canvas.DrawImage(Properties.Resources.school, _facilityBar[SCHOOLS]);
            canvas.DrawImage(Properties.Resources.medical, _facilityBar[MEDICAL]);
            canvas.DrawImage(Properties.Resources.Government, _facilityBar[GOVERNMENT]);
            canvas.DrawImage(Properties.Resources.powerPlant, _facilityBar[POWER_PLANT]);
            canvas.DrawImage(Properties.Resources.affordableHomes, _facilityBar[AFFORDABLE_HOME]);
            canvas.DrawImage(Properties.Resources.comfortableHouse, _facilityBar[COMFORTABLE_HOME]);
            canvas.DrawImage(Properties.Resources.luxuryhome, _facilityBar[LUXURY_HOME]);
            canvas.DrawImage(Properties.Resources.factories, _facilityBar[FACTORY]);
            canvas.DrawImage(Properties.Resources.environmentalFacility, _facilityBar[ENVIRONMENTAL_FACILITY]);
            canvas.DrawImage(Properties.Resources.stores, _facilityBar[STORE]);
            canvas.DrawImage(Properties.Resources.restaurants, _facilityBar[RESTAURANT]);
            canvas.DrawImage(Properties.Resources.offices, _facilityBar[OFFICES]);
        }

        // Draw the grid itself 
        void DrawGrid(Graphics canvas)
        {
            for (int cols = 0; cols < _grid.GetLength(0); cols++)
            {
                for (int rows = 0; rows < _grid.GetLength(1); rows++)
                {
                    canvas.DrawRectangle(blackPen, _grid[cols, rows]);
                }
            }
        }

        //Draw the image in each of the grid rectangles
        void DrawImages(Graphics canvas)
        {
            for (int cols = 0; cols < _grid.GetLength(0); cols++)
            {
                for (int rows = 0; rows < _grid.GetLength(1); rows++)
                {
                    canvas.DrawImage(_thePlanet.GetImage(cols, rows), _grid[cols, rows]); 
                }
            }
        }
        

        private void SimSpaceForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw the grid of rectangle of the form 
            DrawGrid(e.Graphics);
            DrawFacilityBar(e.Graphics);
            DrawImages(e.Graphics);
        }

        private void SimSpaceForm_MouseUp(object sender, MouseEventArgs e)
        {
            // If the user is trying to make a facility, do the following
            if (facilityBeingMadeIndex != FACILITY_NOT_BEING_MADE)
            {
                // Go through all grid squares to figure out which one that the user let go of the building 
                for (int cols = 0; cols < _grid.GetLength(0); cols++)
                {
                    for (int rows = 0; rows < _grid.GetLength(1); rows++)
                    {
                        // Find out which grid location the user let go of the mouse 
                        // so that a facility can be made 
                        if (_grid[cols, rows].Contains(e.Location))
                        {
                            // Make an emergency service facility
                            if (facilityBeingMadeIndex == EMERGENCY_SERVICE)
                            {
                                _thePlanet.MakeEmergencyService(cols, rows);
                                EmergencyService tempEmergencyService = new EmergencyService();
                                // Subtract the facility's cost from the user's money
                                _thePlanet.Money -= tempEmergencyService.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == SCHOOLS)
                            {
                                _thePlanet.MakeSchool(cols, rows);
                                Schools tempSchool = new Schools();
                                _thePlanet.Money -= tempSchool.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == MEDICAL)
                            {
                                _thePlanet.MakeMedical(cols, rows);
                                Medical tempMedical = new Medical();
                                _thePlanet.Money -= tempMedical.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == GOVERNMENT)
                            {
                                _thePlanet.MakeGovernment(cols, rows);
                                Government tempGovernment = new Government();
                                _thePlanet.Money -= tempGovernment.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == POWER_PLANT)
                            {
                                _thePlanet.MakePowerPlant(cols, rows);
                                PowerPlant tempPowerPlant = new PowerPlant();
                                _thePlanet.Money -= tempPowerPlant.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == LUXURY_HOME)
                            {
                                _thePlanet.MakeLuxuryResidence(cols, rows);
                                LuxuryResidence tempLuxuryResidence = new LuxuryResidence();
                                _thePlanet.Money -= tempLuxuryResidence.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == COMFORTABLE_HOME)
                            {
                                _thePlanet.MakeComfortableResidence(cols, rows);
                                ComfortableResidence tempComfortableResidence = new ComfortableResidence();
                                _thePlanet.Money -= tempComfortableResidence.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == AFFORDABLE_HOME)
                            {
                                _thePlanet.MakeAffordableResidence(cols, rows);
                                AffordableResidence tempAffordableResidence = new AffordableResidence();
                                _thePlanet.Money -= tempAffordableResidence.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == FACTORY)
                            {
                                _thePlanet.MakeFactory(cols, rows);
                                Factories tempFactory = new Factories();
                                _thePlanet.Money -= tempFactory.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == ENVIRONMENTAL_FACILITY)
                            {
                                _thePlanet.MakeEnvironmentalFacility(cols, rows);
                                EnvironmentalFacilities tempEnvironmentalFacility = new EnvironmentalFacilities();
                                _thePlanet.Money -= tempEnvironmentalFacility.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == STORE)
                            {
                                _thePlanet.MakeStore(cols, rows);
                                Stores tempStore = new Stores();
                                _thePlanet.Money -= tempStore.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == RESTAURANT)
                            {
                                _thePlanet.MakeRestaurant(cols, rows);
                                Restaurants tempRestaurant = new Restaurants();
                                _thePlanet.Money -= tempRestaurant.BuildCost;
                            }
                            else if (facilityBeingMadeIndex == OFFICES)
                            {
                                _thePlanet.MakeOffice(cols, rows);
                                Factories tempOffice = new Factories();
                                _thePlanet.Money -= tempOffice.BuildCost;
                            }
                            //MessageBox.Show("Grid Location clicked was: (" + cols + "," + rows + ")");
                            Refresh();
                            // Update the planet's money 
                            lblMoney.Text = "Money: " + _thePlanet.Money.ToString();
                        }
                    }
                }
            }
        }

        private void SimSpaceForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Go through all the grid squares to figure out which one was clicked 
            for (int cols = 0; cols < _grid.GetLength(0); cols++)
            {
                for (int rows = 0; rows < _grid.GetLength(1); rows++)
                {
                    if (_grid[cols, rows].Contains(e.Location))
                    {
                        MessageBox.Show("Grid Location clicked was: (" + cols + "," + rows + ")");
                        break;
                    }
                }
            }
            // Set no facility being made 
            facilityBeingMadeIndex = FACILITY_NOT_BEING_MADE;
            // Check if a building on the building bar has been clicked 
            for (int facilityIndex = 0; facilityIndex < _facilityBar.Length; facilityIndex++)
            {
                // If the mouse was clicked on the building bar I need know that a building 
                // attempt is being made by the user 
                if (_facilityBar[facilityIndex].Contains(e.Location))
                {
                    facilityBeingMadeIndex = facilityIndex;
                }
            }
        }

        // Random number generator used for asteroid attack
        public static Random _numberGenerator = new Random();

        // What happens everytime 3s passes
        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            // Increase the month by 1
            _thePlanet.Month++;
            // Output the month 
            lblMonth.Text = "Month: " + _thePlanet.Month.ToString();
            // Call the UpdateTotals and UpdateResidentialPopulation subprgram 
            _thePlanet.UpdateTotals();
            _thePlanet.UpdateResidentialPopulation();
            // Find a number between 1 and 100 and store it to the variable asteroidAttackNumber
            double asteroidAttackNumber = _numberGenerator.Next(1, 100);
            // If the number is 1, o the following
            if (asteroidAttackNumber == 1)
            {
                // Create a double variable score to store the score returned from CalculateScore()
                double score = _thePlanet.CalculateScore();
                // Disable timer
                tmrGameTime.Enabled = false;
                // Make all labels not visible except title label
                lblMoney.Visible = false;
                lblMonth.Visible = false;
                lblPollution.Visible = false;
                lblPopulation.Visible = false;
                lblPower.Visible = false;

                // Print out text informing user that game has ended in label and messagebox
                lblTitle.Text = "GAME OVER";
                MessageBox.Show("GAME OVER. Your score is " + score.ToString());
            }
            // Output all the updated variables
            lblMoney.Text = "Money: " + _thePlanet.Money;
            lblPopulation.Text = "Population: " + _thePlanet.PlanetPopulation.ToString();
            lblPollution.Text = "Pollution: " + _thePlanet.TotalPollution.ToString();
            lblPower.Text = "Power: " + _thePlanet.TotalPower.ToString();
        }

        private void SimSpaceForm_DragDrop(object sender, DragEventArgs e)
        {
            string[,] coordinates = (string[,])e.Data.GetData(DataFormats.Bitmap, false);
            foreach (int coordinate in coordinates[0, 0]) ;
            MessageBox.Show(coordinates.ToString());
        }

        private void SimSpaceForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
