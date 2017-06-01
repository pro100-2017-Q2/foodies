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
using System.Windows.Threading;
using VirtualPantry.Recipes;
using VirtualPantry.ThePantry;

namespace VirtualPantry.Stretch
{
    /// <summary>
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        public MainWindow main;
        private RecipeWindow recipeWindow;
        private DispatcherTimer _timer;
        TimeSpan _time;
        TimeSpan paused;
        private PantryWindow pantry;
        private ConversionChart conversionChart;

        public Timer(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            pantry = new PantryWindow(mainWindow);
            conversionChart = new ConversionChart(mainWindow);

        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

            _time = new TimeSpan(int.Parse(HourLabel.Text),int.Parse(SecondsLabel.Text),0);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                TimeLeftLabel.Content = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            paused = _time;
            _timer.Stop();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            TimeLeftLabel.Content = (_time - _time).ToString();
            HourLabel.Text = "0";
            SecondsLabel.Text = "0";
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

        private void ConversionChartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            conversionChart.Show();
            this.Hide();
        }
    }
}
