using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
	/// Code to handle button clicks on the Main Menu
	/// </summary>
	public sealed partial class MainMenu : Page
	{
		public MainMenu()
		{
			this.InitializeComponent();
		}
		private void MathsCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MathsCalculator));
		}

		private void MortgageCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MortgageCalculator));
		}

		private void CurrencyConverterButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(CurrencyConverter));
		}

		private void TripCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(TripCalculator));
		}

		private async void MMGCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			MessageDialog dialogMessage = new MessageDialog("MMG Calculator C# code will be developed later");
			await dialogMessage.ShowAsync();
			return;
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Exit();
			return;
		}

		private async void BmiCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
				MessageDialog dialogMessage = new MessageDialog("BMI Calculator C# code will be developed later");
				await dialogMessage.ShowAsync();
				return;
		}
	}
}
