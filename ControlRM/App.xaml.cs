using Xamarin.Forms;

namespace ControlRM
{
    #region Globales
    public enum TiposModulos
    {
        Recepciones,
        Refrigeracion,
        ClorinacionAgua
    }
    #endregion
    public partial class App : Application
    {
        #region Referencias
        public App()
        {
            InitializeComponent();

            MainPage = new Main();
        }
        #endregion
        #region Eventos
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
        #endregion
    }
}
