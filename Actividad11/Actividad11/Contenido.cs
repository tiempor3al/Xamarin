using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Actividad11
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

			//Le indicamos al ListView de donde tomar los datos
			listView.ItemsSource = ObtenListaFrutas();
			//Le indicamos al listview que plantilla utilizar
			listView.ItemTemplate = new DataTemplate(typeof(FrutasCell));

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = { listView }
			};
		}

		public List<Frutas> ObtenListaFrutas()
		{
			var lista = new List<Frutas> ();

			lista.Add (new Frutas{Nombre = "Platano", Imagen = "http://www.importancia.org/wp-content/uploads/platano.jpg"});
			lista.Add (new Frutas{Nombre = "Pina", Imagen = "http://2.bp.blogspot.com/-Bw0n6k40hD0/T-yH2CGcHyI/AAAAAAAAAI8/kZEiZ_sbq2w/s1600/Pi%C3%B1a_con_hojaStevia.jpg"});


			return lista;
		}
	}
}

