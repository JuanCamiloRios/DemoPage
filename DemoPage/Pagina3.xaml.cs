using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPage
{
    public partial class Pagina3 : ContentPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private async void Btn1_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void Btn2_Clicked(object sender, System.EventArgs e)
        {
              await Navigation.PopAsync();
        }

        private async void Btn3_Clicked(object sender, System.EventArgs e)
        {
            
            await Navigation.PushModalAsync(new Pagina4());
        }
    }
}
