using System;
using System.Windows.Forms;
namespace TechnicalApp
{
	public class Driver
	{
		//Declaring starting insurance premium
		private static double premium = 500;
		public static string driverName;

		public static double Premium
		{
			get
			{
				return premium;
			}

			set
			{
				premium = value;
			}
		}

		//Method to get driver name via user input
		public static void name()
		{
			Console.WriteLine("Please Enter Driver Name");
			driverName = Console.ReadLine();
		}

		//Method to get driver's occupation and adjust premium accordingly
		public static void job()
		{
			Console.WriteLine("Please Enter Driver Occupation");
			string driverOcc = Console.ReadLine();

			if (driverOcc == "Chauffer")		//Increases insurance premium by 10% if 
			{					//drivers job is Chauffer
				Premium += (Premium * .1);
			}
			else if (driverOcc == "Accountant")	//Decrease insurance premium by 10% if
			{					//driver is an Accountant
				Premium -= (Premium * .1);
			}
			else
			{
				Console.WriteLine("Invalid Occupation");	//Lets the user know that an incorrect
				job();						//occupation has been entered and runs
			}							//the method again
		}

		//Method to check the drivers age against the start date of the insurance policy
		public static void policyStartAge()
		{
			DateTime birthDate;													//Asks the user to input a DOB
			Console.WriteLine("Please Enter Driver DOB in Format MM/DD/YYYY");	
			birthDate = DateTime.Parse(Console.ReadLine());

			DateTime policyStartDate;											
			DateTime today = DateTime.Today;									
			Console.WriteLine("Please Enter the Policy Start Date in Format MM/DD/YYYY");   //Asks the user to input the policy
			policyStartDate = DateTime.Parse(Console.ReadLine());                           //start date

			if (policyStartDate < today)				//Checks the policy start date compared to todays date
			{							//If policy start date is before todays date then an error
				Console.WriteLine("Start Date of Policy");	//message is displayed
			}


			int age = policyStartDate.Year - birthDate.Year;	//method to check the age of driver at the start of the
			if (birthDate > policyStartDate.AddYears(-age))		//policy. Assigned value to 'age' 
				age--;

			Console.WriteLine(age);

			if (age <= 25)				//if age is less than or equal to 25 then total insurance premium is 
			{                               	//increased by 20%.
				Premium += (premium * .2);
			}
			else
			{
				Premium -= (premium * .1);	//if age is greater than 25 then insurance premium is reduced by 10%
			}

			if (age < 21) 				//if age is less than 21 then error message is displayed
			{
				Console.WriteLine("Age of Youngest Driver");
			}
			else if (age > 75)			//if age is greater than 75 then error message is displayed
			{
				Console.WriteLine("Age of Oldest Driver");
			}

		}

	}
}

