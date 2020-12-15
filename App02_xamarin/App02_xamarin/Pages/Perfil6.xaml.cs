using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_Xamarin.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil6 : ContentPage
    {
        public Perfil6()
        {
            InitializeComponent();
        }

        private void btEnviar_Clicked(object sender, EventArgs e)
        { 
          //Parametros para Envio //
            string rem = etReme.Text;
            string des = etDest.Text;
            string ass = etAssum.Text;
            string texto = etTexto.Text;

            string url = "mailto:" + des + "?subject=" + ass + "&body" + texto;
            Device.OpenUri(new Uri(url));
        }
    }
}