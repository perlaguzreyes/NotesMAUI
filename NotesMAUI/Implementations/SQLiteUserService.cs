using System;
using NotesMAUI.Data;
using NotesMAUI.Models;
using NotesMAUI.Services;

namespace NotesMAUI.Implementations
{
	public class SQLiteUserService : INoteUserService
    {
        public NoteLogin GetUser(string username, string password)
        {
            var notes = DBService.GetInstance().Database.Table<NoteLogin>().FirstOrDefault(u => u.User == username && u.Password == password);
            return notes;
        }
        public NoteLogin GetUserId(int id)
        {
            var notes = DBService.GetInstance().Database.Table<NoteLogin>().FirstOrDefault(u => u.IdLogin == id);
            return notes;
        }

        public bool Save(NoteLogin noteLogin)
        {
            DBService.GetInstance().Database.Insert(noteLogin);
            return true;
        }

        public bool Update(NoteLogin noteLogin)
        {
            DBService.GetInstance().Database.Update(noteLogin);
            return true;
        }

        public async Task<bool> SaveAsync(NoteLogin noteLogin)
        {
            await DBService.GetInstance().DatabaseAsync.InsertAsync(noteLogin);
            //await Task.Run(() => Save(note));
            return true;
        }

        public async Task<bool> UpdateAsync(NoteLogin noteLogin)
        {
            await DBService.GetInstance().DatabaseAsync.UpdateAsync(noteLogin);
            return true;
        }

        public async Task<NoteLogin> GetUserIdAsync(int id)
        {
            var notes = await DBService.GetInstance().DatabaseAsync.Table<NoteLogin>().FirstOrDefaultAsync(u => u.IdLogin == id);
            return notes;
        }

        public async Task<NoteLogin> GetUserAsync(string username, string password)
        {
            var notes = await DBService.GetInstance().DatabaseAsync.Table<NoteLogin>().FirstOrDefaultAsync(u => u.User == username && u.Password == password);
            return notes;
        }
    }
}



