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

namespace VirtualPantry.Recipes
{
    /// <summary>
    /// Interaction logic for Recipe.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public MainWindow main;
        public RecipeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private void homeButton_Clicked(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
}
