using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using System.ComponentModel;



namespace OrtoMESH
{
	public partial class LipusPage : ContentPage
	{
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new PatientPage());
		}


		public LipusPage()
		{


			InitializeComponent();
			progressBar.ProgressTo(1, 800000, Easing.Linear);

		}

	}
}
