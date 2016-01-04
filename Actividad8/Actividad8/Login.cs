using System;
using Xamarin.Forms;

namespace Actividad8
{
	public class Login: ContentPage
	{
		public Login ()
		{
			//El objeto Uri es el que contiene la dirección web
			var uri = new Uri("http://img05.deviantart.net/8f6d/i/2016/004/0/9/004___yellow_by_mei_xing-d9mpjad.jpg");

			//Creamos un imagen que se adapte a su tamaño
			var image = new Image { Aspect = Aspect.AspectFit };

			//Le indicamos a la imagen de donde tiene que cargarse
			image.Source = ImageSource.FromUri(uri);


			StackLayout stackLayout = new StackLayout
			{
				Spacing = 20, 
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					image
				}
			};


			this.Content = stackLayout;
			//Device.OnPlatform permite modificar el propiedades segun la plataforma. En este caso iOS
			//Ver https://developer.xamarin.com/guides/xamarin-forms/working-with/platform-specifics/
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}

