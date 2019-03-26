
using AlunoConectadoV100.Interface;
using AlunoConectadoV100.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AlunoConectadoV100.ViewModels
{
    public class HorarioViewModel : Horario
    {
       
        private readonly IConexaoBD conexaoBD;
        private ObservableCollection<Horario> horarios;
        private bool _atualizando = false;
        public bool Atualizando
        {
            get
            {
                return _atualizando;
            }
            set
            {



                SetProperty(ref _atualizando, value);
            }
        }
        public ICommand AtualizarCommand
        {
            get
            {
                return new Command(t =>
                {

                    Atualizando = true;
                    Task.Delay(1000).ContinueWith(a =>
                    {
                        RemoverDados();
                        Task.Delay(1000).ContinueWith(y =>
                        {
                            AtualizarDados();
                        });
                    });
                    Task.Delay(2000).ContinueWith(async =>
                    {
                        Atualizando = false;
                    });

                });
            }
        }
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
        
       public HorarioViewModel()
        {
            conexaoBD = DependencyService.Get<IConexaoBD>();
            Items = new ObservableCollection<Horario>()
            {
                 
            };
            AtualizarDados();
            
        }

        private  void AtualizarDados()
        {
             conexaoBD.ConexaoHorarioAsync(lista =>
             {
                 //foreach (Horario item in lista)
                    // horarios.Remove(item);
                 foreach (Horario item in lista)
                     horarios.Add(item);
                 
                     
             });
        }
        private void RemoverDados()
        {
            conexaoBD.ConexaoHorarioAsync(lista =>
            {
                foreach (Horario item in lista)
                    horarios.Clear();
            });

        }
    }
}
