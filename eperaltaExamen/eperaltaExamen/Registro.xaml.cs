using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eperaltaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            txtUsuarioSesion.Text = usuario;

        }

        private void btnCalcularPago_Clicked(object sender, EventArgs e)
        {
            double pagoinicial = double.Parse(txtPagoInicial.Text);
            double Cuota = 0.00;
            if (pagoinicial < 3000 && pagoinicial >= 0)
            {
                Cuota = ((3000 - pagoinicial) / 3) + (0.05 * 3000);
                txtTotal.Text = Cuota.ToString();
            }
            else
            {
                DisplayAlert("Alerta", "EL NOMTO INGRESADO NO ES CORRECTO", "Cerrar");
                txtPagoInicial.Text = "";

            }


        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Elemento guardado con exito", "Cerrar");

            Navigation.PushAsync(new Resumen(txtUsuarioSesion.Text, txtTotal.Text, txtUsuario.Text, txtPagoInicial.Text));

        }
    }
}