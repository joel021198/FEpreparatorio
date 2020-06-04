using Xamarin.Forms;
using Xamarinpreparcial2.ViewModels;

namespace Xamarinpreparcial2
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new ListProductView();
         
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
