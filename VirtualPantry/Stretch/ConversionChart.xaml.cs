using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VirtualPantry.Enums;
using VirtualPantry.Recipes;

namespace VirtualPantry.Stretch
{
	/// <summary>
	/// Interaction logic for ConversionChart.xaml
	/// </summary>
	public partial class ConversionChart : Window
	{
		public MainWindow main;

		public ConversionChart(MainWindow mainWindow)
		{
			//InitializeComponent();
			main = mainWindow;
			OriginalUnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
			ConvertedUnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
		}

		private void homeButton_Click(object sender, RoutedEventArgs e)
		{
			main.Show();
			this.Hide();
		}

		private void OriginalAmountUpButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				int originalAmount = int.Parse(OriginalAmountLabel.Text);
				originalAmount++;
				OriginalAmountLabel.Text = originalAmount.ToString();
			}
			catch
			{
				OriginalAmountLabel.Text = "0";
			}
		}

		private void OriginalAmountDownButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				int originalAmount = int.Parse(OriginalAmountLabel.Text);
				if (originalAmount > 0)
				{
					originalAmount--;
				}
				OriginalAmountLabel.Text = originalAmount.ToString();
			}
			catch
			{
				OriginalAmountLabel.Text = "0";
			}
		}

	}
}
