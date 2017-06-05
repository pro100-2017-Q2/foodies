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
        private Stretch.Calendar calendar;
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
            calendar = new Stretch.Calendar(mainWindow);
		}

        public PantryWindow()
        {
        }

       
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as MenuItem).IsSubmenuOpen = true;
        }

        private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as MenuItem).IsSubmenuOpen = false;
        }


        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void CalendarMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
