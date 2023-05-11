using System;
using NotesMAUI.Models;

namespace NotesMAUI.Services
{
	public interface INoteUserService : INoteUserServiceAsync
    {
        #region Sync methods
        bool Save(NoteLogin noteLogin);
        bool Update(NoteLogin noteLogin);
        NoteLogin GetUser(string username, string password);
        NoteLogin GetUserId(int id);
        #endregion
    }

    public interface INoteUserServiceAsync
    {
        #region async methoods
        Task<bool> SaveAsync(NoteLogin noteLogin);
        Task<bool> UpdateAsync(NoteLogin noteLogin);
        Task<NoteLogin> GetUserAsync(string username, string password);
        Task<NoteLogin> GetUserIdAsync(int id);
        #endregion
    }
}

