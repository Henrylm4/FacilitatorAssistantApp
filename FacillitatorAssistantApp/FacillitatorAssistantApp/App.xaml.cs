using FacillitatorAssistantApp.Data;
using FacillitatorAssistantApp.Páginas;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacillitatorAssistantApp
{
    public partial class App : Application
    {
        // se crea o se inicia la base de datos al iniciar la app
        static DatabaseQuery database;
        public static DatabaseQuery Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TestName.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
