using MobilePhone.ViewModels;
using System.Windows;

namespace MobilePhone
{
	public partial class MainWindow : Window
	{
		private MainWindowViewModel ViewModel;

		public MainWindow()
		{
			InitializeComponent();

			ViewModel = new MainWindowViewModel(this);

			this.DataContext = ViewModel;

			ViewModel.ReturnToHomeScreen();
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
