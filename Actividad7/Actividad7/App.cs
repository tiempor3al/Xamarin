using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Actividad7
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			//Creamos una lista de paginas de tipo ContentPage. 
			//Hasta ahora nuestra lista no tiene ningun elemento
			List<ContentPage> pages = new List<ContentPage> ();

			//Creamos un arreglo de colores con 3 elementos, Red, Green, y Blue
			Color[] colors = { Color.Red, Color.Green, Color.Blue };

			//Por cada color agregamos un nuevo objeto de tipo ContentPage a la lista
			foreach (Color c in colors) {
				pages.Add (new ContentPage { Content = new StackLayout {

						//Cada pagina tiene como elementos un BoxView (un rectángulo) con 
						//uno de los colores definidos en el arreglo
						Children = {
							new BoxView {
								Color = c,
								//El BoxView deberá ocupar toda la pantalla
								VerticalOptions = LayoutOptions.FillAndExpand
							}
						}
					}
				});
			}

			//Agregamos las páginas al carouselPage
			return new CarouselPage {
				Children = { pages [0],
					pages [1],
					pages [2] }
			};
		}
	}
}

