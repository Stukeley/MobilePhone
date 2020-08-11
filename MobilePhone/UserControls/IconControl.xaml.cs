using MobilePhone.ViewModels;
using System.Windows.Controls;

namespace MobilePhone.UserControls
{
	public partial class IconControl : UserControl
	{
		public IconControlViewModel ViewModel;

		public IconControl()
		{
			InitializeComponent();

			ViewModel = new IconControlViewModel();

			this.DataContext = ViewModel;
		}
	}
}
