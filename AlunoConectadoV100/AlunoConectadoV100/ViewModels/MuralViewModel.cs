using AlunoConectadoV100.Interface;
using AlunoConectadoV100.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AlunoConectadoV100.ViewModels
{
    public class MuralViewModel : Mural
    {
        //private readonly IFileSystem _salvartexto;
       // private bool salvando = false;
        private ObservableCollection<Mural> murais;
        private bool _atualizando = false;
        private readonly IConexaoBD conexaoDB;
       
        
       
       // private readonly INavigationService navigationService;
      
      
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
       
        public ObservableCollection<Mural> Items
        {
            get
            {
                return murais;
            }
            set
            {
               SetProperty(ref murais, value); 
            }
            
        }
        public ICommand AtualizarCommand
        {
            get
            {
                return new Command(t  =>
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
       
       

        public MuralViewModel()
        {

            // navigationService = DependencyService.Get<INavigationService>();
            //_salvartexto = DependencyService.Get<IFileSystem>();
            conexaoDB = DependencyService.Get<IConexaoBD>();
            Items = new ObservableCollection<Mural>()
            {
               
            };
             AtualizarDados();
            //HoraLocal(DateTime);
            //RemoverDados();
            //BtnSalvarDados();
            
        }

        private void AtualizarDados()
        {
              conexaoDB.ConexaoMuralAsync(lista =>
               { foreach (Mural item in lista) murais.Add(item); });
            
        }
        private void RemoverDados()
        {
                conexaoDB.ConexaoMuralAsync(lista =>
                {
                    foreach (Mural item in lista)
                       murais.Clear();
                });
           
        }

        
       
    }
}
