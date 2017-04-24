using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class DoctorPage : ContentPage
	{
		void SearchPatientButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new SearchPatientPage());
		}

		void AddProcessButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new ProcessPage());
		}

		void Back_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new MainPage());
		}

		public DoctorPage()
		{
			InitializeComponent();
		}
	}
}
