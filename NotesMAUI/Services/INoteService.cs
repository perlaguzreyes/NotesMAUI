using System;
using NotesMAUI.Models;

namespace NotesMAUI.Services
{
	public interface INoteService : INoteServiceAsync
    {
        #region Sync methods
        bool Save(Note note);
        bool Update(Note note);
        bool Delete(Note note);
        IList<Note> GetNotes(int userId);
        #endregion
	}
    public interface INoteServiceAsync
    {
        #region async methoods
        Task<bool> SaveAsync(Note note);
        Task<bool> UpdateAsync(Note note);
        Task<bool> DeleteAsync(Note note);
        Task<IList<Note>> GetNotesAsync(int userId);
        #endregion
    }
}

