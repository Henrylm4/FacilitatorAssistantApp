using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacillitatorAssistantApp.Páginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Registrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void CrearCuenta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}