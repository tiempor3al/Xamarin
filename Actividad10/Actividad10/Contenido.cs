using System;
using Xamarin.Forms;

namespace Actividad10
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			//El control ListView muestra el contenido en forma de tabla 
			//Con RowHeight le indicamos el alto de cada renglón
			var listView = new ListView
			{
				RowHeight = 40
			};

			//El contenido de la tabla 
			//Por el momento usamos un arreglo de cadenas
			String[] arreglo = new string []
			{
				"Pera",
				"Manzana",
				"Plátano",
				"Mango",
				"Piña"
			};

			//Le indicamos al ListView de donde tomar los datos
			listView.ItemsSource = arreglo;

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}
	}
}

