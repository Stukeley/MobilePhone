using MaterialDesignThemes.Wpf;
using MobilePhone.Base;
using MobilePhone.Models;
using MobilePhone.UserControls;
using System.Windows;
using System.Windows.Media;

namespace MobilePhone.ViewModels
{
	public class IconControlViewModel : ViewModelBase
	{
		private PackIconKind _kind;

		public PackIconKind Kind
		{
			get
			{
				return _kind;
			}
			set
			{
				_kind = value;
				OnPropertyChanged();
			}
		}

		private SolidColorBrush _foreground;

		public SolidColorBrush Foreground
		{
			get
			{
				return _foreground;
			}
			set
			{
				_foreground = value;
				OnPropertyChanged();
			}
		}

		private PhoneApp _app;

		public PhoneApp App
		{
			get
			{
				return _app;
			}
			set
			{
				_app = value;
				SetAppName();
				OnPropertyChanged();
			}
		}

		private string _appName;

		public string AppName
		{
			get
			{
				return _appName;
			}
			set
			{
				_appName = value;
				OnPropertyChanged();
			}
		}

		public IconControlViewModel()
		{
			Kind = PackIconKind.Close;
			Foreground = new SolidColorBrush(Colors.Black);

			SetAppName();
		}

		private void SetAppName()
		{
			switch (App)
			{
				case PhoneApp.Photos:
					break;
				case PhoneApp.Camera:
					break;
				case PhoneApp.Settings:
					break;
				case PhoneApp.Calculator:
					AppName = "Calculator";
					break;
			}
		}

		/// <summary>
		/// Creates a new Control based on the specified App, then adds it to MainWindow's content grid.
		/// </summary>
		public void RunApp()
		{
#if DEBUG
			Logging.Logger.Instance.InsertLog(new Logging.LogEntry($"Attempting to run App: {App}"));
#endif

			switch (App)
			{
				case PhoneApp.Photos:
					break;
				case PhoneApp.Camera:
					break;
				case PhoneApp.Settings:
					break;
				case PhoneApp.Calculator:

					var calculator = new CalculatorControl();

					foreach (var win in Application.Current.Windows)
					{
						if (win is MainWindow m)
						{
							m.ViewModel.ChangeContent(calculator);
						}
					}

					break;

				default:
					return;
			}
#if DEBUG
			Logging.Logger.Instance.InsertLog(new Logging.LogEntry($"Changed content to {App} successfully."));
#endif

		}
	}
}
