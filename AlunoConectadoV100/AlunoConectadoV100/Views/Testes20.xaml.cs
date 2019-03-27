using AlunoConectadoV100.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlunoConectadoV100.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Testes20 : ContentPage
    {
       

        public Testes20()
        {
            InitializeComponent();
            BindingContext = new HorarioViewModel();

            
        }

        
    }
}
