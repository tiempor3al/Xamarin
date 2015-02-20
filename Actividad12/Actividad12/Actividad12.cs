using System;

using Xamarin.Forms;
using System.Collections.Generic;


namespace Actividad12
{
	public class App : Application
	{
		public App ()
		{

			var button = new Button {
				Text = "click"
			};

			var label = new Label ();

			button.Clicked += async (sender, e) => {
				var result = await DependencyService.Get<IScan>().Scan();
				label.Text = result;
			};


			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						button,
						label
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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

