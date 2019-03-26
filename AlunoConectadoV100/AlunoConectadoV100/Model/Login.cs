using AlunoConectadoV100.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoConectadoV100.Model
{
    public class Login : BaseViewModel
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { SetProperty(ref nome, value); }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { SetProperty(ref senha, value); }
        }


    }
}
