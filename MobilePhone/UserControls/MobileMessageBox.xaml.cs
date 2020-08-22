using System.Windows;

namespace MobilePhone.UserControls
{
	public partial class MobileMessageBox : Window
	{
		private static MessageBoxResult _result = MessageBoxResult.OK;
		private static MobileMessageBox _messageBox;

		public enum MobileMessageBoxIcon
		{
			Information, Warning, Error
		}

		public enum MobileMessageBoxButtons
		{
			OkCancel, YesNo
		}

		public MobileMessageBox()
		{
			InitializeComponent();

			this.Owner = Application.Current.MainWindow;
		}

		public static MessageBoxResult Show(string title, string content, MobileMessageBoxIcon icon, MobileMessageBoxButtons buttons)
		{
			_messageBox = new MobileMessageBox()
			{
				TitleBox = { Text = title },
				ContentBox = { Text = content }
			};

			SetMessageBoxIcon(icon);
			SetMessageBoxButtons(buttons);

			_messageBox.ShowDialog();

			return _result;
		}

		private static void SetMessageBoxIcon(MobileMessageBoxIcon icon)
		{
			switch (icon)
			{
				case MobileMessageBoxIcon.Information:
					_messageBox.MessageBoxPackIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.InformationVariant;
					break;

				case MobileMessageBoxIcon.Warning:
					_messageBox.MessageBoxPackIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WarningOutline;
					break;

				case MobileMessageBoxIcon.Error:
					_messageBox.MessageBoxPackIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Exclamation;
					break;
			}
		}

		private static void SetMessageBoxButtons(MobileMessageBoxButtons buttons)
		{
			switch (buttons)
			{
				case MobileMessageBoxButtons.OkCancel:
					_messageBox.YesButton.Visibility = Visibility.Collapsed;
					_messageBox.NoButton.Visibility = Visibility.Collapsed;
					_messageBox.OkButton.Visibility = Visibility.Visible;
					_messageBox.CancelButton.Visibility = Visibility.Visible;
					break;

				case MobileMessageBoxButtons.YesNo:
					_messageBox.YesButton.Visibility = Visibility.Visible;
					_messageBox.NoButton.Visibility = Visibility.Visible;
					_messageBox.OkButton.Visibility = Visibility.Collapsed;
					_messageBox.CancelButton.Visibility = Visibility.Collapsed;
					break;
			}
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			_result = MessageBoxResult.Cancel;
			_messageBox.Close();
			_messageBox = null;
		}

		private void OkButton_Click(object sender, RoutedEventArgs e)
		{
			_result = MessageBoxResult.OK;
			_messageBox.Close();
			_messageBox = null;
		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			_result = MessageBoxResult.Cancel;
			_messageBox.Close();
			_messageBox = null;
		}

		private void YesButton_Click(object sender, RoutedEventArgs e)
		{
			_result = MessageBoxResult.Yes;
			_messageBox.Close();
			_messageBox = null;
		}

		private void NoButton_Click(object sender, RoutedEventArgs e)
		{
			_result = MessageBoxResult.No;
			_messageBox.Close();
			_messageBox = null;
		}
	}
}
