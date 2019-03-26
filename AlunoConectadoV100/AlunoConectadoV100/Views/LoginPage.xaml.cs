using AlunoConectadoV100.Interface;
using AlunoConectadoV100.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlunoConectadoV100.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}