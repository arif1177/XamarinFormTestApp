using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinFormTestApp.Service;

namespace XamarinFormTestApp
{
    public partial class App : Application
    {
        static DBSQLite localSQLiteDB;
        public static DBSQLite DBSQLite//This code defines a DBSQLite property that creates a new DBSQLite instance as a singleton (From microsoft documentation)
        {
            get
            {
                if(localSQLiteDB == null)
                {
                    localSQLiteDB = new DBSQLite(System.IO.Path.Combine(FileSystem.AppDataDirectory, "quote.db3"));
                }
                return localSQLiteDB;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());//setting the main page
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
