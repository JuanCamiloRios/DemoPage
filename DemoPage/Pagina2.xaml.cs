using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Pagina2 : ContentPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Label.Text = string.Empty;
            await Navigation.PushAsync(new Pagina3());

        }

        private async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            this.Label.Text = string.Empty;
            var resp = await DisplayAlert("Test", "Esta seguro de realizar el test", "si", "no");
            if (resp)
            {

                await DisplayAlert("Inicio de test", "Super Bienvenido", "Aceptar");
                var opcion = await DisplayActionSheet("Opciones", "Cancelar", null, "Opcion 1", "Opcion2", "Opcion 3");
                Label.Text = opcion.ToString();
            }
            else
            {
                await DisplayAlert("Test fallido", "En otra ocasión sera", "Aceptar");

            }
        }

    }
}
