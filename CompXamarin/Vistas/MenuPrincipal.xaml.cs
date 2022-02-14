using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompXamarin.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public IList<Mcomidas> Comida { get; private set;}

        public MenuPrincipal()
        {
            InitializeComponent();

            Comida = new List<Mcomidas>();
            Comida.Add(new Mcomidas
            {
                Nombre = "Imagen circular",
                Imagen = "emoji.png"
            });
            Comida.Add(new Mcomidas
            {
                Nombre = "Alertas",
                Imagen = "alerta.png"
            });
            Comida.Add(new Mcomidas
            {
                Nombre = "Tarjetas",
                Imagen = "tarjeta.png"
            });
            Comida.Add(new Mcomidas
            {
                Nombre = "Fechas",
                Imagen = "fecha.png"
            });

            BindingContext = this;

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Mcomidas seleccion = e.Item as Mcomidas;
            if(seleccion.Nombre == "Tarjetas")
            {
                Navigation.PushAsync(new Tarjetas());
            }
            if (seleccion.Nombre == "Alertas")
            {
                Navigation.PushAsync(new Alertas());
            }
            if (seleccion.Nombre == "Imagen circular")
            {
                Navigation.PushAsync(new circularImagen());
            }
            if (seleccion.Nombre == "Fechas")
            {
                Navigation.PushAsync(new fechaHora());
            }
        }
    }
}