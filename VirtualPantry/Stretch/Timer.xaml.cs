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

namespace VirtualPantry.Stretch
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        public MainWindow main;
        private RecipeWindow recipeWindow;

        public Timer(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }

        public Timer(RecipeWindow recipeWindow)
        {
            this.recipeWindow = recipeWindow;
        }

        private void homeButton_Clicked(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
}
