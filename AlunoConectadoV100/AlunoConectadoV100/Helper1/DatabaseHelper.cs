using AlunoConectadoV100.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlunoConectadoV100.Helper1
{
    public class DatabaseHelper
    {
        static SQLiteConnection sQLiteConnection;
        public const string DbFileName = "HorariosDB.db";
        public DatabaseHelper()
        {
            // criar uma pasta base local para dispositivo
            var pasta = new LocalRootFolder();
            var arquivo = pasta.CreateFile(DbFileName, CreationCollisionOption.OpenIfExists);
            var arquivo = pasta.CreateFile();
            sQLiteConnection = new SQLiteConnection(arquivo.Path);
            sQLiteConnection.CreateTable<Horario>();
        }
        public List<Horario> GetAllHorarios()
        {
            return (from data in sQLiteConnection.Table<Horario>() select data).ToList();
        }
        public void DeleteAllHorarios()
        {
            sQLiteConnection.DeleteAll<Horario>();
        }
        public void UpdatePedido(Horario horario)
        {
            sQLiteConnection.Update(horario);
        }
    }
}
