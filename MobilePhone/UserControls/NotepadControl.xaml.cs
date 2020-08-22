using MobilePhone.ViewModels;
using System.Windows.Controls;

namespace MobilePhone.UserControls
{
	public partial class NotepadControl : UserControl
	{
		public NotepadControlViewModel ViewModel;

		public NotepadControl()
		{
			InitializeComponent();

			ViewModel = new NotepadControlViewModel();

			this.DataContext = ViewModel;
		}
	}
}
