using System;
namespace TechnicalApp
{
	public class Driver
	{
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

		public static void name()
		{
			Console.WriteLine("Please Enter Driver Name");
			driverName = Console.ReadLine();
		}

		public static void job()
		{
			Console.WriteLine("Please Enter Driver Occupation");
			string driverOcc = Console.ReadLine();

			if (driverOcc == "Chauffer")
			{
				Premium += (Premium * .1);
			}
			else if (driverOcc == "Accountant")
			{
				Premium -= (Premium * .1);
			}
			else
			{
				Console.WriteLine("Invalid Occupation");
				job();
			}
		}


		public static void policyStartAge()
		{
			DateTime birthDate;
			Console.WriteLine("Please Enter Driver DOB in Format MM/DD/YYYY");
			birthDate = DateTime.Parse(Console.ReadLine());

			DateTime policyStartDate;
			DateTime today = DateTime.Today;
			Console.WriteLine("Please Enter the Policy Start Date in Format MM/DD/YYYY");
			policyStartDate = DateTime.Parse(Console.ReadLine());

			if (policyStartDate > today)
			{
				Console.WriteLine("Start Date of Policy");
			}


			int age = policyStartDate.Year - birthDate.Year;
			if (birthDate > policyStartDate.AddYears(-age))
				age--;

			Console.WriteLine(age);

			if (age <= 25)
			{
				Premium += (premium * .2);
			}
			else
			{
				Premium -= (premium * .1);
			}

			if (age < 21)
			{
				Console.WriteLine("Age of Youngest Driver");
			}
			else if (age > 75)
			{
				Console.WriteLine("Age of Oldest Driver");
			}

		}

	}
}

