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
using Windows.UI.Popups;

	//Author: Matthew Wilson
	//Number: 001057769
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MathsCalculator : Page
	{
		public MathsCalculator()
		{
			this.InitializeComponent();
		}

		private async void AddButton_Click(object sender, RoutedEventArgs e)
		{
			double num1 = 0, num2 = 0, sum = 0;
			try
			{
				num1 = double.Parse(num1TextBox.Text);
			}
			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num1TextBox.Focus(FocusState.Programmatic); return;
			}
			try
			{
				num2 = double.Parse(num2TextBox.Text);
			}

			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num2TextBox.Focus(FocusState.Programmatic); return;
			}
			sum = num1 + num2;
			addTextBox.Text = sum.ToString();
		}

		private async void SubButton_Click(object sender, RoutedEventArgs e)
		{
			double num1 = 0, num2 = 0, sum = 0;
			try
			{
				num1 = double.Parse(num1TextBox.Text);
			}
			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num1TextBox.Focus(FocusState.Programmatic); return;
			}
			try
			{
				num2 = double.Parse(num2TextBox.Text);
			}

			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num2TextBox.Focus(FocusState.Programmatic); return;
			}
			sum = num1 - num2;
			addTextBox.Text = sum.ToString();
		}

		private async void TimesButton_Click(object sender, RoutedEventArgs e)
		{
			double num1 = 0, num2 = 0, sum = 0;
			try
			{
				num1 = double.Parse(num1TextBox.Text);
			}
			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num1TextBox.Focus(FocusState.Programmatic); return;
			}
			try
			{
				num2 = double.Parse(num2TextBox.Text);
			}

			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num2TextBox.Focus(FocusState.Programmatic); return;
			}
			sum = num1 * num2;
			addTextBox.Text = sum.ToString();
		}

		private async void DivideButton_Click(object sender, RoutedEventArgs e)
		{
			double num1 = 0, num2 = 0, sum = 0;
			try
			{
				num1 = double.Parse(num1TextBox.Text);
			}
			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num1TextBox.Focus(FocusState.Programmatic); return;
			}
			try
			{
				num2 = double.Parse(num2TextBox.Text);
			}

			catch (Exception theException)
			{
				var dialogMessage = new MessageDialog("Error! Please enter a valid number. " +
				theException.Message);
				await dialogMessage.ShowAsync(); num2TextBox.Focus(FocusState.Programmatic); return;
			}
			sum = num1 / num2;
			addTextBox.Text = sum.ToString();
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}
	}
}
