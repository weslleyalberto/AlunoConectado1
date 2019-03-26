using AlunoConectadoV100.Interface;
using AlunoConectadoV100.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlunoConectadoV100.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EscolhaPage : ContentPage
    {
        public EscolhaPage()
        {
            InitializeComponent();
            BindingContext = new EscolhaViewModel();
                      
           
        }
    }
}