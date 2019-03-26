using AlunoConectadoV100.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoConectadoV100.Model
{
   public class Mural : BaseViewModel
    {
        
        private int id;

        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); } 
        }
        
        private string data;

        public string Data
        {
            get { return data;  }
            set { SetProperty(ref data, value); }
        }
        private string assunto;

        public string Assunto
        {
            get { return assunto; }
            set { SetProperty(ref assunto, value); }
        }
        private string informacao;

        public string Informacao
        {
            get { return informacao; }
            set { SetProperty(ref informacao, value); }
        }
        private String  valor;

        public String  Valor
        {
            get { return valor; }
            set { SetProperty(ref valor, value); }
        }
        private List<Mural> muraus;

        public List<Mural> Muraus
        {
            get { return muraus; }
            set { SetProperty(ref muraus, value); }
        }


    }
}
