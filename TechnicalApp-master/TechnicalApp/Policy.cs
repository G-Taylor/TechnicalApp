using System.Windows.Forms;
using System;
namespace TechnicalApp
{

    class Policy
	{
      
        //Main method for the policy
        [STAThread]
        public static void Main(string[] args)
		{
            Application.EnableVisualStyles();
            TechAppForm form1 = new TechAppForm();
            form1.ShowDialog();
                                              
		}
	}
}
