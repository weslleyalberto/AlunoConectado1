using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AlunoConectadoV100.Droid.AcessoDB;
using AlunoConectadoV100.Interface;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
[assembly: Xamarin.Forms.Dependency(typeof(AcessoDB))]
namespace AlunoConectadoV100.Droid.AcessoDB
{
    public class AcessoDB : IAcessoDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var nomeDB = "AlunosConectados.db";
            var caminhoPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var caminho = Path.Combine(caminhoPasta, nomeDB);
            return new SQLiteAsyncConnection(caminho);
        }
    }
}