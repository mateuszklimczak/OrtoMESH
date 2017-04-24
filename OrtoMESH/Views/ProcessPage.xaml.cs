using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class ProcessPage : ContentPage
	{

		void Scan_Clicked(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("itms-apps://itunes.apple.com/pl/app/scanner-structure-sensor-sample/id891169722?mt=8"));

		}

		void Confirm_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("New patient","New patient has been added","OK");
		}

		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
		public ProcessPage()
		{
			InitializeComponent();
		}


	}
}
