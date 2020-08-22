using MobilePhone.Models;
using MobilePhone.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace MobilePhone.UserControls
{
	public partial class CalculatorControl : UserControl
	{
		private CalculatorControlViewModel ViewModel;

		public CalculatorControl()
		{
			InitializeComponent();

			ViewModel = new CalculatorControlViewModel();

			this.DataContext = ViewModel;
		}

		private void ButtonNumber_Click(object sender, RoutedEventArgs e)
		{
			int num = 0;

			switch ((sender as Button).Name)
			{
				case "Button1":
					num = 1;
					break;
				case "Button2":
					num = 2;
					break;
				case "Button3":
					num = 3;
					break;
				case "Button4":
					num = 4;
					break;
				case "Button5":
					num = 5;
					break;
				case "Button6":
					num = 6;
					break;
				case "Button7":
					num = 7;
					break;
				case "Button8":
					num = 8;
					break;
				case "Button9":
					num = 9;
					break;
				case "Button0":
					num = 0;
					break;
			}

			AddToResultBlock(num);
		}

		private void ButtonPeriod_Click(object sender, RoutedEventArgs e)
		{
			if (!ResultBlock.Text.Contains('.'))
			{
				ResultBlock.Text += ".";
			}
		}

		private void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
		{
			if (ResultBlock.Text[0] == '-')
			{
				ResultBlock.Text.Remove(0);
			}
			else
			{
				ResultBlock.Text = "-" + ResultBlock.Text;
			}
		}

		private void ButtonOperation_Click(object sender, RoutedEventArgs e)
		{
			MathsOperation operation = MathsOperation.None;

			switch ((sender as Button).Name)
			{
				case "ButtonEquals":
					operation = MathsOperation.None;
					break;
				case "ButtonPlus":
					operation = MathsOperation.Add;
					break;
				case "ButtonMinus":
					operation = MathsOperation.Subtract;
					break;
				case "ButtonMultiply":
					operation = MathsOperation.Multiply;
					break;
				case "ButtonDivide":
					operation = MathsOperation.Divide;
					break;
				case "ButtonExponent":
					operation = MathsOperation.Power;
					break;
				case "ButtonModulo":
					operation = MathsOperation.Modulo;
					break;
				case "ButtonNaturalLog":
					operation = MathsOperation.NaturalLog;
					break;
				case "ButtonLog10":
					operation = MathsOperation.Log10;
					break;
				case "ButtonSqrt":
					operation = MathsOperation.Sqrt;
					break;
				case "ButtonEx":
					operation = MathsOperation.Ex;
					break;
			}

			OperationButtonClicked(operation);
		}

		/// <summary>
		/// Method used for executing an operation and displaying its result. Called whenever a button is pressed.
		/// If two operations have been called (eg. num1 + num2 +), then the first operation is executed, and the second one is stored for later.
		/// </summary>
		/// <param name="newOperation">The operation pressed, None if pressed Equals</param>
		private void OperationButtonClicked(MathsOperation newOperation)
		{
			// Do the check here

			if (ViewModel.MathsOperation != MathsOperation.None)
			{
				// If the operation isn't none, then perform that operation and save the new one
				// eg. value1 + value2 + value3 = ; first add value1+value2, then add value3

				string result = "ERR";

				ViewModel.NumbersAsStrings.Add(ResultBlock.Text);

				switch (ViewModel.MathsOperation)
				{
					case MathsOperation.Add:
						result = ViewModel.Add();
						break;
					case MathsOperation.Subtract:
						result = ViewModel.Subtract();
						break;
					case MathsOperation.Multiply:
						result = ViewModel.Multiply();
						break;
					case MathsOperation.Divide:
						result = ViewModel.Divide();
						break;
					case MathsOperation.Power:
						result = ViewModel.RaiseToPower();
						break;
					case MathsOperation.Modulo:
						result = ViewModel.Modulo();
						break;
					case MathsOperation.NaturalLog:
						result = ViewModel.NaturalLog();
						break;
					case MathsOperation.Log10:
						result = ViewModel.Log10();
						break;
					case MathsOperation.Sqrt:
						result = ViewModel.Sqrt();
						break;
					case MathsOperation.Ex:
						result = ViewModel.Ex();
						break;
				}

				ResultBlock.Text = result;
			}
			else
			{
				ResultBlock.Text = "";
			}

			ViewModel.NumbersAsStrings.Clear();
			ViewModel.NumbersAsStrings.Add(ResultBlock.Text);

			ViewModel.MathsOperation = newOperation;
		}

		private void ButtonClear_Click(object sender, RoutedEventArgs e)
		{
			ClearResultBlock();
		}

		private void ClearResultBlock()
		{
			ResultBlock.Text = "0";
			ViewModel.NumbersAsStrings.Clear();
		}

		private void AddToResultBlock(int num)
		{
			if (ResultBlock.Text == "0")
			{
				ResultBlock.Text = "";
			}

			ResultBlock.Text += num.ToString();

			// TODO: might have to call this for ViewBox instead (this should update font size to fit the viewbox)
			ResultBlock.UpdateLayout();
		}
	}
}
