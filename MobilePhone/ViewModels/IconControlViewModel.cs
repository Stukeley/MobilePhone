using MaterialDesignThemes.Wpf;
using MobilePhone.Base;
using MobilePhone.Models;
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
				OnPropertyChanged();
			}
		}

		public IconControlViewModel()
		{
			Kind = PackIconKind.Close;
			Foreground = new SolidColorBrush(Colors.Black);
		}

		public void RunApp()
		{
			switch (App)
			{

			}
		}
	}
}
