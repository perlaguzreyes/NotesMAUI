using System;
using NotesMAUI.Data;
using NotesMAUI.Models;
using NotesMAUI.Services;

namespace NotesMAUI.Implementations
{
	public class SQLiteNoteService : INoteService
    {

        public bool Delete(Note note)
        {
            DBService.GetInstance().Database.Delete(note);
            return true;
        }

        public async Task<bool> DeleteAsync(Note note)
        {
            await DBService.GetInstance().DatabaseAsync.DeleteAsync(note);
            return true;
        }

        public IList<Note> GetNotes(int userId)
        {
            var notes = DBService.GetInstance().Database.Table<Note>().Where(n => n.IdLogin == userId).ToList();
            return notes;
        }

        public async Task<IList<Note>> GetNotesAsync(int userId)
        {
            var notes = await DBService.GetInstance().DatabaseAsync.Table<Note>().Where(n => n.IdLogin == userId).ToListAsync();
            return notes;
        }

        public bool Save(Note note)
        {
            DBService.GetInstance().Database.Insert(note);
            return true;
        }

        public async Task<bool> SaveAsync(Note note)
        {
            await DBService.GetInstance().DatabaseAsync.InsertAsync(note);
            //await Task.Run(() => Save(note));
            return true;
        }

        public bool Update(Note note)
        {
            DBService.GetInstance().Database.Update(note);
            return true;
        }

        public async Task<bool> UpdateAsync(Note note)
        {
            await DBService.GetInstance().DatabaseAsync.UpdateAsync(note);
            return true;
        }
    }
}

