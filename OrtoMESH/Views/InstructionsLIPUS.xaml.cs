using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class InstructionsLIPUS : ContentPage
	{
		void Start_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Lipus treatment","","Start");
			Navigation.PushModalAsync(new LipusPage());
		}

		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public InstructionsLIPUS()
		{
			InitializeComponent();
		}
	}
}
