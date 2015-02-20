using System;

using Xamarin.Forms;

namespace Actividad11
{
	public class App : Application
	{



		public App()
		{
			//Esta es la nueva manera de crear la aplicacion
			MainPage = new NavigationPage (new Contenido());
		}


	}
}

