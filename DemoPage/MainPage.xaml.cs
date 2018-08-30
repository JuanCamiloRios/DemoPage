using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void btn_Clicked(object sender, System.EventArgs e)
        {
            panel.Children.add(new Button()
            {
                Text = $"boton{panel.Children.Count + 1}"
            });
        }
    }
}