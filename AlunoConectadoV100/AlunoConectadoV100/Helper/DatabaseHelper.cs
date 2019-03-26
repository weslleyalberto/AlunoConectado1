using AlunoConectadoV100.Model;
using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlunoConectadoV100.Helper
{
    public class DatabaseHelper
    {
        static SQLiteConnection sQLiteConnection;
        public const string DbFileName = "HorariosDB.db";

        public DatabaseHelper()
        {
            var pasta = new LocalRootFolder();
            var arquivo = pasta.CreateFile(DbFileName, PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            sQLiteConnection.CreateTable<Horario>();
        }
        public List<Horario> GetAllHorariosData()
        {
            return (from data in sQLiteConnection.Table<Horario>() select data).ToList();
        }
        public void UpdateHorario(Horario horarios)
        {
            sQLiteConnection.Update(horarios);
        }
    }
}
