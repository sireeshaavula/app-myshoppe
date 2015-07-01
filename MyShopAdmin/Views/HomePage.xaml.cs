﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyShopAdmin
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
			Title = "Shoppe Admin";
			ButtonManage.Clicked += (sender, e) => 
			{
				Navigation.PushAsync(new StoresPage());
			};

			ButtonFeedback.Clicked += (sender, e) => 
			{
				Navigation.PushAsync(new FeedbackListPage());
			};
		}
	}
}

