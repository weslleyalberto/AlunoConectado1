using AlunoConectadoV100.Interface;
using AlunoConectadoV100.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace AlunoConectadoV100.ViewModels
{
    public class LoginViewModel : Login
    {
        public ICommand LoginCommand
        {
            get;
            private set;
        }
        public ICommand LimparCommand
        {
            get;
            private set;
        }
        private readonly IMessage message;
        private readonly INavigationService navigationService;
        public LoginViewModel()
        {
            message = DependencyService.Get<IMessage>();
            navigationService = DependencyService.Get<INavigationService>();
            LoginCommand = new Command(LoginCmd);
            LimparCommand = new Command(LimparCmd);
        }
        private void LoginCmd()
        {
            if(this.Nome == "alunos" && this.Senha == "12345")
            {
                this.navigationService.NavegarParaHorario();
            }
            else
            {
                message.ExebirMessagemAsync("Nome do Usuário ou Senha Inválidos!");
            }
        }
        private void LimparCmd()
        {
            this.Nome = null;
            this.Senha = null;
        }


    }
}
