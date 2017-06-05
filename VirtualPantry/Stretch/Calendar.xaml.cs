using System;
using System.Collections.Generic;
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
using VirtualPantry.Recipes;
using VirtualPantry.ThePantry;

namespace VirtualPantry.Stretch
{
    /// <summary>
    /// Interaction logic for Calendar.xaml
    /// </summary>
    public partial class Calendar : Window
    {
        public MainWindow main;
        private ConversionChart conversionChart;
        private Timer timer;
        private PantryWindow pantry;
        private RecipeWindow recipe;

        public Calendar(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            conversionChart = new ConversionChart(mainWindow);
            timer = new Timer(mainWindow);
            pantry = new PantryWindow(mainWindow);
            recipe = new RecipeWindow(mainWindow);
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

        private void ConversionChartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            conversionChart.Show();
            this.Hide();
        }

        private void TimerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            timer.Show();
            this.Hide();
        }

        private void PantryMenuItem_Click(object sender, RoutedEventArgs e)
        {
            pantry.Show();
            this.Hide();
        }

        private void RecipeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            recipe.Show();
            this.Hide();
        }
    }
}
