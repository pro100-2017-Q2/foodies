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
		private int originalAmount;

		public int OriginalAmount
		{
			get { return originalAmount; }
			set { originalAmount = value; FieldChanged(); }
		}


		public ConversionChart(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
			OriginalUnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
			ConvertedUnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
		}

      

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }

		public event PropertyChangedEventHandler PropertyChanged;
		protected void FieldChanged([CallerMemberName] string field = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(field));
			}
		}
	}
}
