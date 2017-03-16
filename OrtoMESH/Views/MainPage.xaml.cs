using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			BackgroundImage = "backgroundimage.ortomesh.jpg" ;
			InitializeComponent();
			Content = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = { Patient, Doctor }
			};
			Patient.Clicked += (sender, e) =>
			{
				Navigation.PushModalAsync(new Patient());
			};

			Doctor.Clicked += (sender, e) =>
			{
				Navigation.PushModalAsync(new Doctor());
			};
		}

		Button Patient = new Button()
		{
			Text = "Patient",
			TextColor = Color.Black,
			WidthRequest = 240,

		};

		Button Doctor = new Button()
		{ 
		    Text = "Doctor",
			TextColor = Color.Black,
			WidthRequest = 240,
		};
	}
}
