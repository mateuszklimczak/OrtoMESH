using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class CalendarPage : ContentPage
	{
		void PatientPageButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
		
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
		public CalendarPage()
		{
			InitializeComponent();
		}
	}
}
