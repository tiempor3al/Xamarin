using System;
using Xamarin.Forms;

namespace Actividad6
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			Label texto = new Label {
				Text = "texto va a cambiar",
				TextColor = Color.Blue
			};

			Button boton = new Button
			{
				Text = "Click para cambiar el texto"
			};

			boton.Clicked += (sender, e) => {
				texto.Text = "haz hecho click en el botón";
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto,
					boton
				}
			};

			ContentPage contentPage = new ContentPage ();
			contentPage.Content = stackLayout;

			//Padding agrega un margen al contenido
			//Device.OnPlatform permite modificar este margen dependiendo de la plataforma IOS, Android y Windows Phone
			//Para saber más sobe Device.OnPlatform revisa 
			contentPage.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);

			return contentPage;
		}
	}
}

