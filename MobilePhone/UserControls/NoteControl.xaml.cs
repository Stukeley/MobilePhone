using MobilePhone.Models;
using MobilePhone.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace MobilePhone.UserControls
{
	public partial class NoteControl : UserControl
	{
		public NoteControlViewModel ViewModel;

		public NoteControl(Note note)
		{
			InitializeComponent();

			ViewModel = new NoteControlViewModel();

			ViewModel.Note = note;

			this.DataContext = ViewModel;
		}

		private void FavouriteIcon_PreviewMouseUp(object sender, MouseButtonEventArgs e)
		{

		}
	}
}
