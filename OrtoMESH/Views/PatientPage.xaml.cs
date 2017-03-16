using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class PatientPage : ContentPage
	{
		public PatientPage()
		{
			BackgroundColor = Color.White;
			InitializeComponent();
			Content = new StackLayout()
			{ 
				Children = { back }
			};

			back.Clicked += (sender, e) =>
			{
				Navigation.PopModalAsync();
			};
		}

		Button back = new Button()
		{
			Text = "back",
			TextColor = Color.Black, 
		};
	}
}
