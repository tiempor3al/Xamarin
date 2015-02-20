using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new Pagina1());
		}
	}
}

