using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class ProcessPage : ContentPage
	{
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
