using MobilePhone.Models;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhone.Database
{
	/// <summary>
	/// The class is responsible for making operations on the Database, including: retrieving, inserting and modifying data, etc.
	/// </summary>
	public static class DatabaseOperations
	{
		/// <summary>
		/// Returns a collection of all Notes from the database.
		/// </summary>
		/// <returns></returns>
		public static List<Note> GetAllNotes()
		{
			List<Note> notes;

			using (var db = new NotesContext())
			{
				notes = db.Notes.ToList();
			}

			return notes;
		}

		/// <summary>
		/// Asynchronously inserts a new note into the database. 
		/// </summary>
		public static async void InsertNoteAsync(Note note)
		{
			using (var db = new NotesContext())
			{
				// If the database contains the note, do not insert it again
				// Example: we take a note out of the database, then try to insert it again

				if (note.Id != 0 && db.Notes.Select(x => x.Id == note.Id).Count() == 0)
				{
					db.Notes.Add(note);
					await db.SaveChangesAsync();
				}
			}
		}
	}
}
