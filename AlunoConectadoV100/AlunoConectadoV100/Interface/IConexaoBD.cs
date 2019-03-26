using AlunoConectadoV100.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlunoConectadoV100.Interface
{
    public interface IConexaoBD
    {
        Task ConexaoHorarioAsync(Action <IEnumerable<Horario>> action);
        Task ConexaoMuralAsync(Action<IEnumerable<Mural>> action);

    }
}
