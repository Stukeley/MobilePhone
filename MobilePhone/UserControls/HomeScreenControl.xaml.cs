using System.Windows.Controls;
using System.Windows.Media;

namespace MobilePhone.UserControls
{
	public partial class HomeScreenControl : UserControl
	{
		public HomeScreenControl()
		{
			InitializeComponent();

			CalculatorIcon.ViewModel.App = Models.PhoneApp.Calculator;
			CalculatorIcon.ViewModel.Kind = MaterialDesignThemes.Wpf.PackIconKind.Calculator;
			CalculatorIcon.ViewModel.Foreground = new SolidColorBrush(Colors.Orange);
		}
	}
}
