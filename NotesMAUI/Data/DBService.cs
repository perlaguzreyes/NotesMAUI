using System;
using NotesMAUI.Models;
using SQLite;

namespace NotesMAUI.Data
{
	public class DBService
	{
        private static DBService _instance = null;
        private SQLiteConnection _connection = null;
        private SQLiteAsyncConnection _connectionAsync = null;

        private const string DatabaseName = "notes.db3";

        private DBService()
        {
        }

        public SQLiteConnection Database
        {
            get
            {
                if (_connection == null)
                {
#if __IOS__
                    var basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
#else
                    var basePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
#endif

                    var path = Path.Combine(basePath, DatabaseName);
                    _connection = new SQLiteConnection(path, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite);
                    var tableTypes = new[] { typeof(NoteLogin), typeof(Note) };
                    _connection.CreateTables(CreateFlags.None, tableTypes);
                }

                return _connection;
            }
        }

        public SQLiteAsyncConnection DatabaseAsync
        {
            get
            {
                if (_connectionAsync == null)
                {
#if __IOS__
                    var basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
#else
                    var basePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
#endif

                    var path = Path.Combine(basePath, DatabaseName);
                    _connectionAsync = new SQLiteAsyncConnection(path, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite);
                    var tableTypes = new[] { typeof(NoteLogin), typeof(Note) };
                    _connectionAsync.CreateTablesAsync(CreateFlags.None, tableTypes);
                }

                return _connectionAsync;
            }
        }


        public static DBService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DBService();
            }

            return _instance;
        }
    }
}

