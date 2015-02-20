using System;
using Xamarin.Forms;

namespace Actividad7
{
	public class Pagina2: ContentPage
	{
		public Pagina2 ()
		{
			Label texto = new Label {
				Text = "Página 2",
				TextColor = Color.Green
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto

				}
			};


			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

