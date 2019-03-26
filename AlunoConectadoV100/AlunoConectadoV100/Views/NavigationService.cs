using AlunoConectadoV100.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlunoConectadoV100.Views
{
    public class NavigationService : INavigationService
    {
        public async Task NavegarParaEscolha()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.EscolhaPage());
        }

        public async Task NavegarParaHorario()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.HorariosPage());
        }

       

        public async Task NavegarParaMural()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Views.MuralPage());
        }
    }
}
