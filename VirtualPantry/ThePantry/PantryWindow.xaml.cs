using OverloadingOperators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace VirtualPantry.ThePantry
{
	/// <summary>
	/// Interaction logic for PantryWindow.xaml
	/// </summary>
	public partial class PantryWindow : Window
	{
		private MainWindow main;
		private Pantry p = new Pantry();
		private static ObservableCollection<Ingredients> pantry = new ObservableCollection<Ingredients>
		{
			
		};
		public PantryWindow(MainWindow mainWindow)
		{
			InitializeComponent();
			main = mainWindow;
			PantryGrid.ItemsSource = pantry;
			CategoryComboBox.ItemsSource = Enum.GetValues(typeof(Categories));
			UnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
		}
		private void homeButton_Clicked(object sender, RoutedEventArgs e)
		{
			main.Show();
			this.Hide();
		}
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
