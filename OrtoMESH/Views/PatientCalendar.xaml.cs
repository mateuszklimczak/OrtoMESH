using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class PatientCalendar : ContentPage
	{
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
		void PatientPage_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
		public PatientCalendar()
		{
			InitializeComponent();
		}
	}
}
