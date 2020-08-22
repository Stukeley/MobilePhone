using MobilePhone.Base;
using MobilePhone.UserControls;
using System.Windows.Controls;

namespace MobilePhone.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		private UserControl _content;
		public UserControl Content
		{
			get
			{
				return _content;
			}
			set
			{
				_content = value;
				_window.ContentGrid.Children.Clear();
				_window.ContentGrid.Children.Add(_content);
				OnPropertyChanged();
			}

		}

		private MainWindow _window;

		public MainWindowViewModel(MainWindow window)
		{
			_window = window;
		}

		public void ReturnToHomeScreen()
		{
			_content = new HomeScreenControl();
		}

		public void ChangeContent(UserControl control)
		{
			_content = control;
		}
	}
}
