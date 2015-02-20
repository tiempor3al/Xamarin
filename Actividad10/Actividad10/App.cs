using System;
using Xamarin.Forms;

namespace Actividad10
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new Contenido());
		}
	}
}

