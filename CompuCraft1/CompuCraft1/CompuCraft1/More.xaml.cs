using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace CompuCraft1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class More : ContentPage
	{
		public More ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            // URL a la que quieres navegar
            string url = "https://latam.msi.com/power-supply-calculator"; // URL que deseas abrir

            // Verifica si la URL es válida
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                // Abre la URL en el navegador predeterminado del dispositivo
                await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
            }
            else
            {
                // Manejo de errores si la URL no es válida
                await DisplayAlert("Error", "La URL proporcionada no es válida.", "OK");
            }
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Listas());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }
    }
}