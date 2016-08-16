using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalApp
{
    public partial class TechAppForm : Form
    {
        public TechAppForm()
        {
            InitializeComponent();

        }

        private void TechAppForm_Load(object sender, EventArgs e)
        {
           
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxOcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPolicy_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string driverName = "";             //declaring variables
            string driverOcc = "";
            double Premium = 500;

            driverName = string.Format(txtBoxName.Text.Trim());     //assigning data entered from text boxes from form
            driverOcc = string.Format(txtBoxOcc.Text.Trim());       //to variables

            if (driverOcc == "Chauffer")        //Increases insurance premium by 10% if 
            {                                   //drivers job is Chauffer
                Premium += (Premium * .1);
            }
            else if (driverOcc == "Accountant") //Decrease insurance premium by 10% if
            {                                   //driver is an Accountant
                Premium -= (Premium * .1);
            }
            else
            {
                MessageBox.Show("Incorrect Occupation");    //if occupation doesnt match the two specified,
                txtBoxPremium.Text = "";                    //then error message is displayed and 'Premium'
            }                                               //box is cleared

            DateTime birthDate;                                 //declaring 'birthDate' variable
            birthDate = DateTime.Parse(txtBoxDOB.Text.Trim());  //assigning value to variable from text box in form

            DateTime policyStartDate;                           //declaring 'policyStartDate' variable
            DateTime today = DateTime.Now;                      //declaring 'today' variable and assigning todays date

            policyStartDate = DateTime.Parse(txtBoxPolicy.Text.Trim());     //assigning value to 'policyStartDate'
                                                                            //from text box in form           
            if (policyStartDate < today)
            {                                                   //'if statement' to check if 'policyStartDate' is valid              
                MessageBox.Show("Start Date of Policy");        //If not, then error message is displayed and    
                txtBoxPremium.Text = "";                        //'premium' box is cleared
            }

            int age = policyStartDate.Year - birthDate.Year;    //method to check the age of driver at the start of the
            if (birthDate > policyStartDate.AddYears(-age))     //policy. Assigned value to 'age' 
                age--;

            if (age <= 25)                      //if age is less than or equal to 25 then total insurance premium is 
            {                                   //increased by 20% and displayed in 'premium' box.
                Premium += (Premium * .2);
                txtBoxPremium.Text = Premium.ToString();
            }
            else
            {
                Premium -= (Premium * .1);      //if age is greater than 25 then insurance premium is reduced by 10%
                txtBoxPremium.Text = Premium.ToString();    //and result is displayed in 'premium' box
            }
            
            if (age <21)
            {
                MessageBox.Show("Age of Youngest Driver");      //'if statement' that displays error message if driver
                txtBoxPremium.Text = "";                        //is too young. Also clears the 'Premium' box
            }
            else if (age > 75)
            {
                MessageBox.Show("Age of Oldest Driver");        //'if statement' that displays error message if driver
                txtBoxPremium.Text = "";                        //is too old. Also clears the 'Premium' box
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";           //method that runs off the reset button being clicked
            txtBoxOcc.Text = "";            //resets all of the text boxes to blank
            txtBoxPolicy.Text = "";
            txtBoxPremium.Text = "";
            txtBoxDOB.Text = "";

        }
    }
}
