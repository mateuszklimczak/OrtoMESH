using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class DoctorPage : ContentPage
	{
		public DoctorPage()
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
			Text = "Back",
			TextColor = Color.Black,
		};
	}
}
