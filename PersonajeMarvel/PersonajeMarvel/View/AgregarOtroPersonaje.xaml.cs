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
	public partial class AgregarOtroPersonaje : ContentPage
	{
		public AgregarOtroPersonaje ()
		{
			InitializeComponent ();

            OtroP = new List<OtrosPersonajes>();
        }

        public List<OtrosPersonajes> OtroP { get; set; }
        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            /*   public string EsAmigoOEnemigo { get; set; }
           public string NombreReal { get; set; }
           public string NombrePersonaje { get; set; }
           public int Edad { get; set; }
                */
            OtrosPersonajes np = new OtrosPersonajes();
            np.NombrePersonaje = EntryNombrePersonaje.Text;
            np.NombreReal = EntryNombreReal.Text;
            np.Edad = int.Parse(EntryEdad.Text);
            np.EsAmigoOEnemigo = (EsAmigo.IsToggled) ? "Es amigo" : "Es enemigo";
            OtroP.Add(np);
        }

        private void BtnMostrar_Clicked(object sender, EventArgs e)
        {
            string todosLosPersonajes = "[DATOS PERSONAJES:]\n\n";
            foreach(var i in OtroP)
            {
                todosLosPersonajes += "Nombre personaje: " + i.NombrePersonaje + " / Nombre real: " + i.NombreReal + "/ Edad:" + i.Edad.ToString() + " / Relacion:" + i.EsAmigoOEnemigo+ " \n";
            }
             DisplayAlert("Mensaje" , todosLosPersonajes, "ok");
        }
    }
}