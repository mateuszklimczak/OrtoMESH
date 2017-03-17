using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class PatientPage : ContentPage 
	{
		void PatientCalendarPage_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new PatientCalendar());
		}

		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public PatientPage()
		{
			InitializeComponent();
		
		}
	}
}