using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class SearchPatientPage : ContentPage
	{
		void Back_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public SearchPatientPage()
		{
			InitializeComponent();
			this.BindingContext = new[] {
				"Jan Kowalski",
				"Adam Nowak",
				"Jezus Maria",
				"Antonina Kowalewicz" };

		}
	}
}
