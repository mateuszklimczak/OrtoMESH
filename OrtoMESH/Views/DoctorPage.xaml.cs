using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class DoctorPage : ContentPage
	{
		void Back_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public DoctorPage()
		{
			InitializeComponent();
		}
	}
}
