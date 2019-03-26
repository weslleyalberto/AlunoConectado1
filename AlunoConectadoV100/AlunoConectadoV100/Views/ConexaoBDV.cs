using AlunoConectadoV100.Interface;
using AlunoConectadoV100.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlunoConectadoV100.Views
{
    public class ConexaoBDV : IConexaoBD
    {
        public async Task ConexaoHorarioAsync(Action <IEnumerable<Horario>> action)
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://alunoconectado.com/api/horarios/");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var lista = JsonConvert.DeserializeObject<IEnumerable<Horario>>(await response.Content.ReadAsStringAsync());
                action(lista);
            }
        }
        public async Task ConexaoMuralAsync(Action<IEnumerable<Mural>> action)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://alunoconectado.com/api/murals");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var lista = JsonConvert.DeserializeObject<IEnumerable<Mural>>(await response.Content.ReadAsStringAsync());
                action(lista);
            }
        }
    }
}
