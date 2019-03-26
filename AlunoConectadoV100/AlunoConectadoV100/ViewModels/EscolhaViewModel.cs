using AlunoConectadoV100.Interface;
using AlunoConectadoV100.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AlunoConectadoV100.ViewModels
{

    public class EscolhaViewModel : BaseViewModel 
    {
        public ObservableCollection<Horario> Items
        {
            get
            {
                return horarios;
            }
            set
            {
                horarios = value;
                SetProperty(ref horarios, value);
            }
        }


        public ICommand MuralCommand
        {
            get;
            private set;
        }
        public ICommand HorarioCommand
        {
            get;
            private set;
        }
        private ObservableCollection<Horario> horarios;
        private readonly INavigationService navigationServices;
        private readonly IConexaoBD conexaoBD;

        public EscolhaViewModel()
        {
            conexaoBD = DependencyService.Get<IConexaoBD>();
            Items = new ObservableCollection<Horario>()
            {

            };
            navigationServices = DependencyService.Get<INavigationService>();
            MuralCommand = new Command(MuralCmd);
            HorarioCommand = new Command(HorarioCmd);
            AtualizarDados();

        }

        private void AtualizarDados()
        {
            conexaoBD.ConexaoHorarioAsync(lista =>
            {
                //foreach (Horario item in lista)
                // horarios.Remove(item);
                foreach (Horario item in lista)
                    horarios.Add(item);


            });
        }

        private void MuralCmd()
        {
            navigationServices.NavegarParaMural();
        }
        private void HorarioCmd()
        {
            navigationServices.NavegarParaHorario();
        }

        
    }
}
