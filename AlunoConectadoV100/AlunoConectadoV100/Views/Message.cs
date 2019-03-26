using AlunoConectadoV100.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlunoConectadoV100.Views
{
    public class Message : IMessage
    {
        public async Task ExebirMessagemAsync(string mensagem)
        {
            await App.Current.MainPage.DisplayAlert("Login", mensagem, "OK");
        }
    }
}
