using System;
using static System.Console;
using System.Windows;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Drivers are concerned with the mileage their automobiles get.
    /// One driver has kept track of several tankfuls of gasoline by 
    /// recording the miles driven and gallons used for each tankful. 
    /// Develop a C# app that will input the miles driven and gallons
    /// used (both as integers) for each tankful. The app should calculate
    /// and display the miles per gallon obtained for each tankful and 
    /// display the combined miles per gallon obtained for all tankfuls
    /// up to this point. All averaging calculations should produce
    /// floating-point results. Display the miles per gallons on one line
    /// and the total miles per gallons on another, both rounded to the
    /// nearest hundredth, immediately after each input. Use the Console
    /// class’s ReadLine method and sentinel-controlled iteration
    /// (e.g. when miles driven are negative, the loop ends) to
    /// obtain the data from the user.
    /// </summary>

}

 
namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        //============================================================
        // system generated code creates the GUI
        public Form1()
        {
            InitializeComponent();
        }

        //============================================================        
        // Calculate & Display MPG
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // numeric variables declared here
            int miles, gallons;
            double mpg;

            // Get miles driven, convert and assign to miles
            miles = int.Parse(txtMiles.Text);

            // Get gallons used, convert and assign to gallons
            gallons = int.Parse(txtGallons.Text);

            // Calculate MPG. MUST (cast) variables to force decimal math.
            // integer math discards fractions so 3/2 is simply 1 and not 1.5
            mpg = (double)miles / (double)gallons;

            // Convert number to string and display the MPG with 3 decimal places (rounds)
            lblMPG.Text = mpg.ToString("N3");
        }


        //============================================================        
        // End the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}