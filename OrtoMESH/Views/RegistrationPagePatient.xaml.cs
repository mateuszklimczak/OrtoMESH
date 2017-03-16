using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class RegistrationPagePatient : ContentPage
	{
		void SignUpButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new PatientPage());
		}

		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
		public RegistrationPagePatient()
		{
			InitializeComponent();
	
		}
	
	}
}
