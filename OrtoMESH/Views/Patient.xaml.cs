using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class Patient : ContentPage
	{
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		void SignUp_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new RegistrationPage());
		}

		void SignIn_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new DoctorPage());
		}
		public Patient()
		{
			InitializeComponent();

		
		}
	}
}