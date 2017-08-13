using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Foreingwin2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ConvertirButton.Clicked += ConvertirButton_Clicked;

        }

        void ConvertirButton_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(SolesEntry.Text))
            {
                DisplayAlert("Error", "Ingresa un valor en soles...", "Aceptar");
                return;
            }

            decimal soles = 0;

            if (!decimal.TryParse(SolesEntry.Text, out soles))
            {
                DisplayAlert("Error", "Ingresa un valor númerico...", "Aceptar");
                return;

            }

            var dolar = soles / 3.25M;
            var euros = soles / 3.8M;
            var libras = soles / 4.5M;

            DolaresEntry.Text = string.Format("${0:N2}", dolar);
            EurosEntry.Text = string.Format("€{0:N2}", euros);
            LibrasEntry.Text = string.Format("£{0:N2}", libras);
        }
    }
    
}
