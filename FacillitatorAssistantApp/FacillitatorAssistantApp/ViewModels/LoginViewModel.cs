using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FacillitatorAssistantApp.ViewModels
{// Clase tipo intent para el Login
    //utilizar el nugget MvvmLightLibs
    public class LoginViewModel :BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;

        #endregion

        #region Properties
        public string EmailTxt //Este es el nombre del Binding en el XAML
        {
            get { return this.email; } // se obtiene el valor puesto en el view por el usuario para ponerlo en el atributo de la clase
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand //Command puesto en el boton 
        {
            get
            {
                return new RelayCommand(Login);
            }
            set
            {

            }
        }


        #endregion

        #region Methods
        private void Login()
        {
            if(EmailTxt.ToString()== "Email@gmail.com" && PasswordTxt.ToString()== "1234")
            {
                Application.Current.MainPage.DisplayAlert("Correcto", "Logrado", "ok");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Incorrecto", "No fue logrado", "ok");

            }
        }
        #endregion

        #region Constructor

        #endregion
    }
}
