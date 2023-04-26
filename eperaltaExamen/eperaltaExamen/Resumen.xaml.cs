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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuariosesion, string Cuota, string usuario, string Pagoinicia)
        {
            InitializeComponent();
            txtUsuariosesion.Text = usuariosesion;
            txtusuario.Text = usuario;
            double Cuota1 = Convert.ToDouble(Cuota);
            double Pagoinicial1 = Convert.ToDouble(Pagoinicia);

            double total = ((Pagoinicial1) + (Cuota1 * 3));
            txtPagoTotal.Text = total.ToString();

        }
    }
}