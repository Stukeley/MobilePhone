using MobilePhone.Base;
using MobilePhone.Models;
using System;
using System.Collections.Generic;

namespace MobilePhone.ViewModels
{
	public class CalculatorControlViewModel : ViewModelBase
	{
		public MathsOperation MathsOperation { get; set; }

		// The numbers can be double but we'll store them as string
		public List<string> NumbersAsStrings { get; set; }

		public CalculatorControlViewModel()
		{
			MathsOperation = MathsOperation.None;

			NumbersAsStrings = new List<string>();
		}

		public string Add()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);
			double num2 = double.Parse(NumbersAsStrings[1]);

			return (num1 + num2).ToString();
		}

		public string Subtract()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);
			double num2 = double.Parse(NumbersAsStrings[1]);

			return (num1 - num2).ToString();
		}

		public string Multiply()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);
			double num2 = double.Parse(NumbersAsStrings[1]);

			return (num1 * num2).ToString();
		}

		public string Divide()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);
			double num2 = double.Parse(NumbersAsStrings[1]);

			if (num2 == 0)
			{
				return "ERR";
			}

			return (num1 / num2).ToString();
		}

		public string RaiseToPower()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);
			double num2 = double.Parse(NumbersAsStrings[1]);

			return Math.Pow(num1, num2).ToString();
		}

		public string Modulo()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);
			double num2 = double.Parse(NumbersAsStrings[1]);

			return (num1 % num2).ToString();
		}

		public string NaturalLog()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);

			if (num1 == 1)
			{
				return "ERR";
			}

			return Math.Log(num1).ToString();
		}

		public string Log10()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);

			if (num1 == 1)
			{
				return "ERR";
			}

			return Math.Log10(num1).ToString();
		}

		public string Sqrt()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);

			if (num1 < 0)
			{
				return "ERR";
			}

			return Math.Sqrt(num1).ToString();
		}

		public string Ex()
		{
			double num1 = double.Parse(NumbersAsStrings[0]);

			return Math.Pow(Math.E, num1).ToString();
		}
	}
}
