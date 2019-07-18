using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PersonajeMarvel.Model;
namespace PersonajeMarvel.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PersonajeView : ContentPage
	{
		public PersonajeView ()
		{
			InitializeComponent ();
		}

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            Personaje p = new Personaje();
            if (!string.IsNullOrEmpty(EntryNombrePersonaje.Text) && !string.IsNullOrEmpty(EntryNombreReal.Text) && !string.IsNullOrEmpty(EntryEdad.Text))
            {
                p.NombrePersonaje = EntryNombrePersonaje.Text;
                p.NombreReal = EntryNombreReal.Text;
                p.Edad = Convert.ToInt16(EntryEdad.Text);
                Navigation.PushAsync(new EvaluarPersonaje(p));
            }
            else
            {
                DisplayAlert("Error", "Npo puedes dejar ningun campo vacio", "OK");
            }
        }
    }
}