using Xamarin.Forms;

namespace AlunoConectadoV100
{
    public partial class App : Application
    {
        public App()
        {

           
            DependencyService.Register<Interface.IConexaoBD, Views.ConexaoBDV>();
           
            DependencyService.Register<Interface.IMessage, Views.Message>();
            DependencyService.Register<Interface.INavigationService, Views.NavigationService>();
            InitializeComponent();
            // XF.Material.Forms.Material.Init(this);
            MainPage = new NavigationPage(new Views.EscolhaPage());
            
        }
       

        protected override void OnStart()
        {
            
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
