using MobilePhone.Base;
using MobilePhone.Models;
using MobilePhone.UserControls;
using System.Collections.Generic;

namespace MobilePhone.ViewModels
{
	public class NotepadControlViewModel : ViewModelBase
	{
		private List<NoteControl> _noteControls;

		public List<NoteControl> NoteControls
		{
			get
			{
				return _noteControls;
			}
			set
			{
				_noteControls = value;
				OnPropertyChanged();
				UpdateNotesScrollViewer();
			}
		}

		private NotepadControl _control;

		public NotepadControlViewModel(NotepadControl control)
		{
			NoteControls = new List<NoteControl>();

			_control = control;
		}

		public void UpdateNotesScrollViewer()
		{
			_control.NotesPanel.Children.Clear();

			foreach (var note in NoteControls)
			{
				_control.NotesPanel.Children.Add(note);
			}
		}

		public void AddToNoteControls(Note note)
		{
			var ctrl = new NoteControl(note)
			{
				Margin = new System.Windows.Thickness(10),
				Height = 50,
				Width = 300
			};

			NoteControls.Add(ctrl);

			UpdateNotesScrollViewer();
		}
	}
}
