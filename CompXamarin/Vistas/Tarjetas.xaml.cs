using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarjetas : ContentPage
    {
        public Tarjetas()
        {
            InitializeComponent();
        }

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnvolver4_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnvolver3_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnvolver2_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}