using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class RegistrationPage : ContentPage
	{
		void SignUpButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new DoctorPage());
		}

		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public RegistrationPage()
		{
			InitializeComponent();
		
		}
	}
}
