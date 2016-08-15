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


		public static void Main(string[] args)
		{
			
			Driver.name();
			Driver.job();
			Driver.policyStartAge();
		}
	}
}
