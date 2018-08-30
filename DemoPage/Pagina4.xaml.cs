using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    
    public partial class Pagina4 : ContentPage
    {
        public Pagina4()
        {
            InitializeComponent();
        }

        private void Cerrar_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
