using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}
		
		private void CalculateButtonClick(object sender, RoutedEventArgs e)
		{
			// MonthlyPayment = BorrowedAmount * [MonthlyInterest *(1+ monthlyInterest)math.pow(repaymentMonths)]  /  [(1+MonthlyInterest)math.pow(repaymentMonths) - 1]
			double borrowedAmount;
			double years;
			double months;
			double yearlyInterest;
			double repaymentMonths;
			double monthlyInterest;
			double monthlyRepayment;

			borrowedAmount = double.Parse(borrowedAmountTextBlock.Text);
			years = double.Parse(yearTextBlock.Text);
			months = double.Parse(monthsTextBlock.Text);
			yearlyInterest = double.Parse(yearlyInterestRateTextBlock.Text);

			repaymentMonths = years * 12;

			monthlyInterest = yearlyInterest / 12;
			monthlyInterestRateTextBlock.Text = monthlyInterest.ToString();


			 monthlyRepayment = (borrowedAmount * monthlyInterest * Math.Pow(1 + monthlyInterest, repaymentMonths)) / (Math.Pow(1 + monthlyInterest, repaymentMonths) - 1);

			monthlyRepaymentTextBlock.Text = monthlyRepayment.ToString("C");
		}

		
	}
}
