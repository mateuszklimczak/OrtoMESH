using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class InstructionsLIPUS : ContentPage
	{
		void Start_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new LipusPage());
			DisplayAlert("Lipus treatment", "I have read the Lipus manual", "Start");
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
