using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class PatientPage : ContentPage
	{
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public PatientPage()
		{
			InitializeComponent();
		
		}
	}
}