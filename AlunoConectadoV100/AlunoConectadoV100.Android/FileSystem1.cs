using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AlunoConectadoV100.Interface;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AlunoConectadoV100.Droid
{
    class FileSystem1 : IFileSystem
    {
        public string LerTexto(string nomeArquivo)
        {
            var camiminhoDocumento = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var caminhoArquivo = Path.Combine(camiminhoDocumento, nomeArquivo);
            return File.ReadAllText(caminhoArquivo);
        }

        public void SalvarTexto(string nomeArquivo, string texto)
        {
            var caminhoDocumento = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var caminhoArquivo = Path.Combine(caminhoDocumento, nomeArquivo);
            File.WriteAllText(caminhoArquivo, texto);
        }
    }
}