using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class Doctor : ContentPage
	{
		public Doctor()
		{
			BackgroundColor = Color.White;
			InitializeComponent();
			Content = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = { login, password, singin, singup, back }
			};

			singin.Clicked += (sender, e) =>
			{
				Navigation.PushModalAsync(new DoctorPage());
			};

			singup.Clicked += (sender, e) =>
			{
				Navigation.PushModalAsync( new RegistrationPage());
			};

			back.Clicked += (sender, e) =>
			{
				Navigation.PopModalAsync();
			};
		}

		Entry login = new Entry()
		{
			Text = "Login",
		};

		Entry password = new Entry()
		{
			Text = "Password",
		};

		Button singin = new Button()
		{ 
		    Text = "Sing in",
			TextColor = Color.Black,
			WidthRequest = 240,
		};

		Button singup = new Button()
		{ 
			Text = "Sing up",
			TextColor = Color.Black,
			WidthRequest = 240,
		};

		Button back = new Button()
		{
			Text = "Back",
			TextColor = Color.Black,
			WidthRequest = 240,
		};
	}
}
