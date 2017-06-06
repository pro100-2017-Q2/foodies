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
using VirtualPantry.ThePantry;

namespace VirtualPantry.Stretch
{
	/// <summary>
	/// Interaction logic for ConversionChart.xaml
	/// </summary>
	public partial class ConversionChart : Window
	{
		public MainWindow main;
        private PantryWindow pantry;
        private Calendar calendar;
        private Timer timer;
        private RecipeWindow recipe;

		public ConversionChart(MainWindow mainWindow)
		{
			//InitializeComponent();
			main = mainWindow;
            pantry = new PantryWindow(mainWindow);
            calendar = new Calendar(mainWindow);
            timer = new Timer(mainWindow);
            recipe = new RecipeWindow(mainWindow);
			OriginalUnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
			ConvertedUnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
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

        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void PantryMenuItem_Click(object sender, RoutedEventArgs e)
        {
            pantry.Show();
            this.Hide();
        }

        private void CalendarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            calendar.Show();
            this.Hide();
        }

        private void TimerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            timer.Show();
            this.Hide();                
        }

        private void RecipeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            recipe.Show();
            this.Hide();
        }
    }
}
