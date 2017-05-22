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
            InitializeComponent();
            main = mainWindow;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }
    }
}
