﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;


namespace OrtoMESH
{
	public partial class LipusPage : ContentPage
	{
		void BackButton_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		public LipusPage()
		{

			InitializeComponent();

		}
	}
}
