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
    public partial class EvaluarPersonaje : ContentPage
    {
        public Personaje PersonajeNuevo { get; set; }
        public EvaluarPersonaje(Personaje ObjPersonaje = null)
        {
            InitializeComponent();
            PersonajeNuevo = new Personaje();
            PersonajeNuevo = ObjPersonaje;

            LabelNombrePersonaje.Text = PersonajeNuevo.NombrePersonaje;
            LabelNombreReal.Text = PersonajeNuevo.NombreReal;
            LabelEdad.Text = PersonajeNuevo.Edad.ToString();
        }

        private void BtnValidar_Clicked(object sender, EventArgs e)
        {
            bool Pelicula = Swith1.IsToggled;
            string Mensaje1 = Pelicula == true ? "Si tiene pelicula activa" : "Por el momento no cuenta con peliculas activas";

            bool Pelicula2 = Swith2.IsToggled;
            string Mensaje2 = Pelicula2 == true ? "Personaje Repetido" : "Personaje no repetido";

            DisplayAlert("Mensaje", Mensaje1 + "\n" + Mensaje2, "OK");

        }

       
        private void BtnNuevoPersonaje_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgregarOtroPersonaje());
        }
    }
}