using MobilePhone.ViewModels;
using System.Windows;

namespace MobilePhone
{
	public partial class MainWindow : Window
	{
		public MainWindowViewModel ViewModel;

		public MainWindow()
		{
			InitializeComponent();

			ViewModel = new MainWindowViewModel(this);

			this.DataContext = ViewModel;

			ViewModel.ReturnToHomeScreen();

#if DEBUG
			Logging.Logger.Instance.InsertLog(new Logging.LogEntry("Started application and set Content to HomeScreen."));
#endif
		}

		private void HomeButton_Click(object sender, RoutedEventArgs e)
		{
			ViewModel.ReturnToHomeScreen();
		}

		private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
			{
				this.DragMove();
			}
		}
	}
}
