using AlunoConectadoV100.Interface;
using AlunoConectadoV100.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlunoConectadoV100.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HorariosPage : ContentPage
    {
        public HorariosPage()
        {
            InitializeComponent();
            //var fullScreen = Xamarin.Forms.DependencyService.Get<IFullScreenMode>();
            //fullScreen.FullScreenModeActivate(true);
            //NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new HorarioViewModel();
        }
        


    }
}