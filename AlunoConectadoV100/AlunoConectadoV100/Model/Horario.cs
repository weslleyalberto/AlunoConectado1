using AlunoConectadoV100.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoConectadoV100.Model
{
    
    public class Horario : BaseViewModel
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }
        private string semana;

        public string Semana
        {
            get { return semana; }
            set { SetProperty(ref semana, value); }
        }
        private string primeiraAula;

        public string Primeira_Aula
        {
            get { return primeiraAula; }
            set { SetProperty(ref primeiraAula, value); }
        }
        private string segundaAula;

        public string Segunda_Aula
        {
            get { return segundaAula; }
            set { SetProperty(ref segundaAula, value); }
        }
        private string terceiraAula;

        public string Terceira_Aula
        {
            get { return terceiraAula; }
            set { SetProperty(ref terceiraAula, value); }
        }
        private string quartaAula;

        public string Quarta_Aula
        {
            get { return quartaAula; }
            set { SetProperty(ref quartaAula, value); }
        }
        private string quintaAula;

        public string Quinta_Aula
        {
            get { return quintaAula; }
            set { SetProperty(ref quintaAula, value); }
        }

    }
}
