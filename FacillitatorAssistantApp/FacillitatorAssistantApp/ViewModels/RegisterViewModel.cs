using FacillitatorAssistantApp.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FacillitatorAssistantApp.ViewModels
{
    public class RegisterViewModel :BaseViewModel
    {
        #region Attributes
        private string username;
        private string fName;
        private string lName;
        private string email;
        private string password;
        private int age;

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

        public string UsernameTxt
        {
            get { return this.username; }
            set { SetValue(ref this.username, value); }
        }

        public string FNameTxt
        {
            get { return this.fName; }
            set { SetValue(ref this.fName, value); }
        }

        public string LNameTxt
        {
            get { return this.lName; }
            set { SetValue(ref this.lName, value); }
        }

        public int AgeTxt
        {
            get { return this.age; }
            set { SetValue(ref this.age, value); }
        }
        #endregion

        #region Commands
        public ICommand RegisterCommand //Command puesto en el boton 
        {
            get
            {
                return new RelayCommand(Register);
            }
            set
            {

            }
        }


        #endregion

        #region Methods
        private async void Register()
        {
            if (string.IsNullOrEmpty(this.EmailTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an email", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.PasswordTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter a Password", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.UsernameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an Username", "Accept");
                return;
            }
            if (AgeTxt.ToString()==null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an Age", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.LNameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an Last Name", "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.FNameTxt))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "You must enter an First Name", "Accept");
                return;
            }


            var user = new User
            {
                Email = EmailTxt.ToLower(),
                Password = PasswordTxt.ToLower(),
                FirstName = FNameTxt.ToLower(),
                LastName = LNameTxt.ToLower(),
                Age = AgeTxt.ToString(),
                Creation_Date = DateTime.UtcNow.Date
            };

            await App.Database.SaveUserAsync(user);//Anade al nuevo usuario creado en el registro
        }
        #endregion

        #region Constructor

        #endregion
    }
}
