using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertaN1 : PopupPage
    {
        public AlertaN1()
        {
            InitializeComponent();
        }

        private void btnOkay_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}