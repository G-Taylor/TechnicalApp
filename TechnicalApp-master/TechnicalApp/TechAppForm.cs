using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TechnicalApp
{
    public partial class TechAppForm : Form
    {
        public string driverName;
        public string driverOcc;
        public DateTime birthDate;
        public DateTime policyStartDate;
        public int noOfDrivers;
        public static decimal Premium;                          //Declaring all variables as public so they can be accessed
        public static decimal premiumPercentage = 1m;           //throughout the program
        public int i;
        public DateTime claim1;
        public DateTime claim2;
        public DateTime claim3;
        public DateTime claim4;
        public DateTime claim5;


        public TechAppForm()
        {
            InitializeComponent();                              //Method to initialize components and set focus 
            this.ActiveControl = txtBoxPolicy;                  //to the policy date entry field
        }

        public void CheckStartDate()                        
        {
            DateTime today = DateTime.Now;                              //Assigning dates to variables via data entered
            policyStartDate = DateTime.Parse(txtBoxPolicy.Text.Trim()); //in corresponding text boxes in form
            
            if (policyStartDate < today)
            {
                MessageBox.Show("Start Date of Policy");                //checking to make sure policy start date is not
                txtBoxPolicy.Text = "";                                 //before todays date
                this.ActiveControl = txtBoxPolicy;
            }
            else
            {
                this.ActiveControl = txtBoxNoOfDrivers;
            }

        }

        public void numberOfDrivers()
        {

            noOfDrivers = int.Parse(txtBoxNoOfDrivers.Text);
            Premium = 500;

            if (noOfDrivers > 5)                                    //Method to check number of drivers on policy
            {                                                       //if value is greater than five or less than one
                MessageBox.Show("Too many drivers");                //an error message is displayed to user
                txtBoxNoOfDrivers.Text = "";
                this.ActiveControl = txtBoxNoOfDrivers;
            }
            else if (noOfDrivers < 1)
                {
                MessageBox.Show("Must Be At Least One Driver");
                txtBoxNoOfDrivers.Text = "";
                this.ActiveControl = txtBoxNoOfDrivers;
            }
            else
            {
                i = 1;
                txtBoxDriverNo.Text = i.ToString();                 
                this.ActiveControl = txtBoxName;
            }

        }

      //  public void drivers()
      //
       // {

       //     while (i < noOfDrivers + 1)
        //    {
        //        i = i + 1;
        //        txtBoxDriverNo.Text = i.ToString();
        //        this.ActiveControl = txtBoxName;

         //   }

         //   txtBoxDriverNo.Text = i.ToString();
         //   calculatePremium();
          //  this.ActiveControl = btnReset;

        //}

        public void jobCheck()
        {
            driverOcc = string.Format(txtBoxOcc.Text.Trim());

            if (driverOcc == "Chauffeur")
            {                                                   //method to check job type and assign value to calculate
                premiumPercentage += 0.05m;                     //premium percentage accordingly
                this.ActiveControl = txtBoxDOB;
            }

            else if (driverOcc == "Accountant")
            {
                premiumPercentage -= 0.05m;
                this.ActiveControl = txtBoxDOB;
            }

            else
            {
                MessageBox.Show("Incorrect Occupation");
                this.ActiveControl = txtBoxOcc;

            }
        }

        public void ageCheck()
        {
            birthDate = DateTime.Parse(txtBoxDOB.Text.Trim());

            int age = policyStartDate.Year - birthDate.Year;
            if (birthDate > policyStartDate.AddYears(-age)) age--;      //method to check driver age.
                                                                        //checks if driver is within limits and adjusts
            if (age < 21)                                               //premium percentage accordingly
            {
                MessageBox.Show("Age of Youngest Driver");
                this.ActiveControl = txtBoxDOB;

            }

            if (age > 75)
            {
                MessageBox.Show("Age of Oldest Driver");
                this.ActiveControl = txtBoxDOB;
            }

            if (age <= 25)
            {
                premiumPercentage = premiumPercentage += 0.1m;
                this.ActiveControl = txtBoxClaim1;
            }

            else
            {
                premiumPercentage = premiumPercentage -= 0.05m;
                this.ActiveControl = txtBoxClaim1;
            }

            

        }

        public void calculatePremium()
        {
            Premium = (Premium * premiumPercentage);                        //method to calculate the premium percentage
            txtBoxPremium.Text = Premium.ToString();
        }

        public void btnEnter_Click(object sender, EventArgs e)
        {

            i = i + 1;
            if (i > noOfDrivers)
            {
                calculatePremium();                                 
                this.ActiveControl = btnReset;
            }

            else
            {
                txtBoxName.Text = "";
                txtBoxDOB.Text = "";
                txtBoxOcc.Text = "";
                driverName = "";
                driverOcc = "";
                DateTime? birthDate = null;
                txtBoxClaim1.Text = "";
                txtBoxClaim2.Text = "";
                txtBoxClaim3.Text = "";
                txtBoxClaim4.Text = "";
                txtBoxClaim5.Text = "";
                DateTime? claim1 = null;
                DateTime? claim2 = null;
                DateTime? claim3 = null;
                DateTime? claim4 = null;
                DateTime? claim5 = null;
                txtBoxDriverNo.Text = i.ToString();
                this.ActiveControl = txtBoxName;
            }

        }

        public void txtBoxPolicy_Leave(object sender, EventArgs e)
        {
            CheckStartDate();
        }

        public void txtBoxNoOfDrivers_Leave(object sender, EventArgs e)
        {
            numberOfDrivers();
        }

        public void txtBoxOcc_Leave(object sender, EventArgs e)
        {
            jobCheck();
        }

        public void txtBoxDOB_Leave(object sender, EventArgs e)
        {
            ageCheck();
        }

        public void txtBoxName_Leave(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxOcc;
        }

        private void txtBoxClaim1_Leave(object sender, EventArgs e)
        {
            if(txtBoxClaim1.Text != "")
            {
                claim1 = DateTime.Parse(txtBoxClaim1.Text.Trim());

                if (claim1 > policyStartDate.AddYears(-1))
                {
                    premiumPercentage = premiumPercentage += .2m;
                }

                else if (claim1 > policyStartDate.AddYears(-5))
                {
                    premiumPercentage = premiumPercentage += .1m;
                }

                else
                {
                    premiumPercentage = premiumPercentage += .0m;
                }

                MessageBox.Show(premiumPercentage.ToString());
                this.ActiveControl = txtBoxClaim2;
                
            }
            
            else
            {
                this.ActiveControl = btnEnter;
            }
        }

        private void txtBoxClaim2_Leave(object sender, EventArgs e)
        {
            if (txtBoxClaim2.Text != "")
            {
                claim2 = DateTime.Parse(txtBoxClaim2.Text.Trim());

                if (claim2 > policyStartDate.AddYears(-1))
                {
                    premiumPercentage = premiumPercentage += .2m;
                }

                else if (claim2 > policyStartDate.AddYears(-5))
                {
                    premiumPercentage = premiumPercentage += .1m;
                }

                else
                {
                    premiumPercentage = premiumPercentage += .0m;
                }

                this.ActiveControl = txtBoxClaim3;
            }

            else
            {
                this.ActiveControl = btnEnter;
            }
        }

        private void txtBoxClaim3_Leave(object sender, EventArgs e)
        {
            if (txtBoxClaim3.Text != "")
            {
                claim3 = DateTime.Parse(txtBoxClaim3.Text.Trim());

                if (claim3 > policyStartDate.AddYears(-1))
                {
                    premiumPercentage = premiumPercentage += .2m;
                }

                else if (claim3 > policyStartDate.AddYears(-5))
                {
                    premiumPercentage = premiumPercentage += .1m;
                }

                else
                {
                    premiumPercentage = premiumPercentage += .0m;
                }

                this.ActiveControl = txtBoxClaim4;
            }

            else
            {
                this.ActiveControl = btnEnter;
            }
        }

        private void txtBoxClaim4_Leave(object sender, EventArgs e)
        {
            if (txtBoxClaim4.Text != "")
            {
                claim4 = DateTime.Parse(txtBoxClaim4.Text.Trim());

                if (claim4 > policyStartDate.AddYears(-1))
                {
                    premiumPercentage = premiumPercentage += .2m;
                }

                else if (claim4 > policyStartDate.AddYears(-5))
                {
                    premiumPercentage = premiumPercentage += .1m;
                }

                else
                {
                    premiumPercentage = premiumPercentage += .0m;
                }

                this.ActiveControl = txtBoxClaim5;
            }

            else
            {
                this.ActiveControl = btnEnter;
            }
        }

        private void txtBoxClaim5_Leave(object sender, EventArgs e)
        {
            if (txtBoxClaim5.Text != "")
            {
                claim5 = DateTime.Parse(txtBoxClaim5.Text.Trim());

                if (claim5 > policyStartDate.AddYears(-1))
                {
                    premiumPercentage = premiumPercentage += .2m;
                }

                else if (claim5 > policyStartDate.AddYears(-5))
                {
                    premiumPercentage = premiumPercentage += .1m;
                }

                
                else
                {
                    premiumPercentage = premiumPercentage += .0m;
                }

            }

            else
            {
                this.ActiveControl = btnEnter;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";           
            txtBoxOcc.Text = "";            
            txtBoxPolicy.Text = "";
            txtBoxPremium.Text = "";
            txtBoxDOB.Text = "";
            txtBoxNoOfDrivers.Text = "";
            txtBoxClaim1.Text = "";
            txtBoxClaim2.Text = "";
            txtBoxClaim3.Text = "";
            txtBoxClaim4.Text = "";
            txtBoxClaim5.Text = "";
            txtBoxDriverNo.Text = "";
            driverName = "";
            driverOcc = "";
            noOfDrivers = 0;
            DateTime? birthDate = null;
            DateTime? policyStartDate = null;
            noOfDrivers = 0;
            Premium = 500;
            premiumPercentage = 1m;
            i = 0;
            DateTime? claim1 = null;
            DateTime? claim2 = null;
            DateTime? claim3 = null;
            DateTime? claim4 = null;
            DateTime? claim5 = null;

    }

        private void TechAppForm_Load(object sender, EventArgs e)
        {
           
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxOcc_Leave(object sender, CancelEventArgs e)
        {

        }

        private void txtBoxDOB_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtBoxPolicy_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNoOfDrivers_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxNoOfDrivers_Validate(object sender, CancelEventArgs e)
        {

        }

    }
}
