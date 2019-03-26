using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlunoConectadoV100.Interface
{
   public interface INavigationService
    {
       
        Task NavegarParaHorario();
        Task NavegarParaEscolha();
        Task NavegarParaMural();
    }
}
