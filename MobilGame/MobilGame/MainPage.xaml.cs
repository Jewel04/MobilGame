using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilGame
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

        
            //test
        }

        public void Submit_Clicked(object sender, EventArgs e)
        {
            var nameValue = name.Text;
        }

        void Entry_Completed(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text; //cast sender to access the properties of the Entry
        }
    }
}
