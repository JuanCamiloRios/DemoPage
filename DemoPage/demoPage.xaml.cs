using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class demoPage : ContentPage
    {
        public demoPage()
        {
            InitializeComponent();
        }

        private async void boton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }
    }
}
