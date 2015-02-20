using System;
using Xamarin.Forms;

namespace Actividad8
{
	public class Login: ContentPage
	{
		public Login ()
		{
			Entry usuario = new Entry { Placeholder = "Usuario" };
			Entry clave = new Entry { Placeholder = "Clave", IsPassword = true };

			Button boton = new Button {
				Text = "Login",
				TextColor = Color.White,
				BackgroundColor = Color.FromHex ("77D065") 
			};

			boton.Clicked += (sender, e) => {

			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Spacing = 20, 
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					usuario,
					clave,
					boton
				}
			};

			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

