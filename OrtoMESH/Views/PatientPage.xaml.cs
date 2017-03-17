using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class PatientPage : ContentPage 
	{

		//void PatientCalendarPage_Clicked(object sender, System.EventArgs e)
		//{
		//	Navigation.PushModalAsync();
		//}
		void Start_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new InstructionsLIPUS());
			DisplayAlert("Get Connected", "To set up your LIPUS, turn on Bluetooth", "OK");
		}

		//void CalendarView_Clicked(object sender, System.EventArgs e)

		//{
		//	Navigation.PushModalAsync();
		//}
		void CalendarPage_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new CalendarPage());
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