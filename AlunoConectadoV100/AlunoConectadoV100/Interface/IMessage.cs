using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlunoConectadoV100.Interface
{
    public  interface IMessage
    {
        Task ExebirMessagemAsync(string mensagem);
    }
}
