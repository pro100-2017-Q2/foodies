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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VirtualPantry.Pantry;
using VirtualPantry.Recipes;
using VirtualPantry.Stretch;

namespace VirtualPantry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PantryWindow pantry;
        public Timer timer;
        public Recipe recipe;
        public ConversionChart conversionChart;
        public MainWindow main;
        public MainWindow()
        {
            InitializeComponent();
            timer = new Timer(this);
        }
        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Show();
            this.Hide();
        }
        private void Navigation(Window window)
        {
            
        }
    }
}