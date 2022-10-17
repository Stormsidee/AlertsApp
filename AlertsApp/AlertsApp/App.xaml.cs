using Xamarin.Forms;
using AlertsApp.View;



namespace AlertsApp
{
    public partial class App : Application
    {
       
        public App()
        {
            InitializeComponent();
            MainPage = new AlertsPage();
            

        }

        protected override void OnStart()
        {
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("#A50000"));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
