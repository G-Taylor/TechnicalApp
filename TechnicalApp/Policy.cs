using System;

namespace TechnicalApp
{

	class Policy
	{
		
		public static double Premium
		{
			get
			{
				return Driver.Premium;
			}

			set
			{
				Driver.Premium = value;
			}
		}

		//Main method for the policy
		public static void Main(string[] args)
		{
			Driver.name();			//Calling 'name' method from 'Driver' class
			Driver.job();			//Calling 'job' method from 'Driver' class
			Driver.policyStartAge();	//Calling 'policyStartAge' method from 'Driver' class
		}
	}
}
