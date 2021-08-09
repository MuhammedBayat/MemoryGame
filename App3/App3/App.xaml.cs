﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App3.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
           // Picture1.Source = ImageSource.FromResource("App3.Resources.1.jpg");
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
