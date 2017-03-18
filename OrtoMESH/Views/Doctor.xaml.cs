using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class Doctor : ContentPage
	{
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		void SignUp_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new RegistrationPage());
		}

		void LogIn_Clicked(object sender, System.EventArgs e)
		{
			bool isLoginOK = false;
			bool isPasswordOk = false;
			if (DoctorLoginEntry.Text.Contains("Test") && DoctorLoginEntry.Text.Length >= 0)
			{
				isLoginOK = true;
			}
			if (DoctorPasswordEntry.Text.Contains("Test") && DoctorPasswordEntry.Text.Length >= 0)
			{
				isPasswordOk = true;
			}
			if (isLoginOK && isPasswordOk)
			{
				Navigation.PushModalAsync(new DoctorPage());
			}
			else
			{
				DisplayAlert("Error", "Wrong Login or Password", "Ok");
			}
		}

		public Doctor()
		{
			InitializeComponent();

		}
	}
}