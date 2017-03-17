using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class PatientPage : ContentPage 
	{
<<<<<<< HEAD
		void PatientCalendarPage_Clicked(object sender, System.EventArgs e)
=======
		void Start_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new InstructionsLIPUS());
			DisplayAlert("Get Connected","To set up your LIPUS, turn on Bluetooth","OK");
		}
		 
		void CalendarView_Clicked(object sender, System.EventArgs e)
>>>>>>> 9ea5634... .
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