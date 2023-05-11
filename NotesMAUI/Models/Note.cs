using System;
using SQLite;
using System.ComponentModel;
namespace NotesMAUI.Models
{
	public class Note
	{
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public int IdLogin { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int NoteTypeInt { get; set; } = (int)NoteType.Default;
        [Ignore]
        public NoteType Type
        {
            get
            {
                return (NoteType)NoteTypeInt;
            }
        }
        public string ImageUrl { get; set; }
    }
    public class NoteLogin
    {
        [PrimaryKey]
        [AutoIncrement]
        public int IdLogin { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; }
    }
    public enum NoteType
    {
        Default = 0,
        Music = 1,
        Image = 2
    }
}

