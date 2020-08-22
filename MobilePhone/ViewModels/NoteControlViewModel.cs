using MobilePhone.Base;
using MobilePhone.Models;
using System;

namespace MobilePhone.ViewModels
{
	public class NoteControlViewModel : ViewModelBase
	{
		private Note _note;

		public Note Note
		{
			get
			{
				return _note;
			}
			set
			{
				_note = value;
				OnPropertyChanged();
			}
		}

		private string _lastModifiedLabel;

		public string LastModifiedLabel
		{
			get
			{
				return _lastModifiedLabel;
			}
			set
			{
				_lastModifiedLabel = value;
				OnPropertyChanged();
			}
		}

		public NoteControlViewModel()
		{
			Note = new Note();
		}

		/// <summary>
		/// Creates a label based on the Note's last modified date. The label shows how long ago the note was modified, eg. 5m, 13h, etc.
		/// </summary>
		public void CreateLastModifiedLabel()
		{
			if (Note.DateLastModified is null)
			{
				LastModifiedLabel = "";
				return;
			}

			var span = DateTime.Now - Note.DateLastModified.Value;

			if (span.Days > 1)
			{
				LastModifiedLabel = span.Days + "d";
			}
			else if (span.Hours > 1)
			{
				LastModifiedLabel = span.Hours + "h";
			}
			else
			{
				LastModifiedLabel = span.Minutes + "m";
			}
		}
	}
}
