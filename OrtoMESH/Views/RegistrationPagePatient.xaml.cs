using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH
{
	public partial class RegistrationPagePatient : ContentPage
	{
		public RegistrationPagePatient()
		{
			BackgroundColor = Color.White;
			InitializeComponent();
			Content = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = { name, surname, age, city, phone, singup, back }
			};

			back.Clicked += (sender, e) =>
			{
				Navigation.PopModalAsync();
			};

			singup.Clicked += (sender, e) =>
			{
				Navigation.PushModalAsync(new PatientPage());
			};
		}
		Entry name = new Entry()
		{
			Text = "Name",
			TextColor = Color.Black,
		};

		Entry surname = new Entry()
		{
			Text = "Surname",
			TextColor = Color.Black,
		};

		Entry age = new Entry()
		{ 
		    Text = "Age",
			TextColor = Color.Black,
		};

		Entry city = new Entry()
		{
			Text = "City",
			TextColor = Color.Black,
		};

		Entry phone = new Entry()
		{
			Text = "Phone number",
			TextColor = Color.Black,
		};

		Button singup = new Button()
		{
			Text = "Singup",
			TextColor = Color.Black,
		};

		Button back = new Button()
		{
			Text = "Back",
			TextColor = Color.Black,
		};
	}
}
