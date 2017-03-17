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
			Navigation.PushModalAsync(new RegistrationPagePatient());
		}

		void LogIn_Clicked(object sender, System.EventArgs e)
		{
			bool isLoginOK = false;
			bool isPasswordOk = false;
			if (PatientLoginEntry.Text.Contains("Mateusz.Klimczak"))
			{
				isLoginOK = true;
			}
			if (PatientPassowordEntry.Text.Contains("Test"))
			{
				isPasswordOk = true;
			}
			if (isLoginOK && isPasswordOk)
			{
				Navigation.PushModalAsync(new PatientPage());
			}
			else 
			{
				DisplayAlert("Error", "Wrong Login or Password", "Ok");
			}
		}
		public Patient()
		{
			InitializeComponent();

		
		}
	}
}