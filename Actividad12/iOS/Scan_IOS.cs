

using System;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency (typeof (Actividad12.Droid.Scan_IOS))]
namespace Actividad12.Droid
{

	public class Scan_IOS: IScan
	{
		public Scan_IOS ()
		{
		}

		//Implementamos el metodo Scan definido en la interfaz IScan
		public async System.Threading.Tasks.Task<String> Scan(){



			var scanner = new ZXing.Mobile.MobileBarcodeScanner();
			var result = await scanner.Scan();

			if(result != null)
				return result.ToString ();

			return string.Empty;
		} 
	}
}

