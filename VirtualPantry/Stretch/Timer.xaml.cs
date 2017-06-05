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
<<<<<<< HEAD


//    public partial class Timer : Window
//    {
//        public MainWindow main;
//        private DispatcherTimer _timer;
//        TimeSpan _time;
//        TimeSpan _default = new TimeSpan(0, 0, 0);
//        private RecipeWindow recipeWindow;
//        TimeSpan paused;
//        private PantryWindow pantry;
//        private ConversionChart conversionChart;
//        TimeSpan _default = new TimeSpan(0,0,0);
//        public Timer(MainWindow mainWindow)
//        {
//            InitializeComponent();
//            main = mainWindow;
//            pantry = new PantryWindow(mainWindow);
//            conversionChart = new ConversionChart(mainWindow);

//        }
//<<<<<<< HEAD

//        public Timer(RecipeWindow recipeWindow)
//        {
//            this.recipeWindow = recipeWindow;
//        }

//        private void _timer_Tick(object sender, EventArgs e)
//        {
//            Duration duration = new Duration(TimeSpan.FromSeconds(20));

//            //progress bar animation
//            System.Windows.Media.Animation.DoubleAnimation doubleanimation = new System.Windows.Media.Animation.DoubleAnimation(200.0, duration);
//            ProgressBar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
//        }

//        private void homeButton_Clicked(object sender, RoutedEventArgs e)
//        {
//            main.Show();
//            this.Hide();
//        }



//        private void StartButton_Click(object sender, RoutedEventArgs e)
//        {
//            int hour = int.Parse(HourLabel.Text);
//            int sec = int.Parse(SecondsLabel.Text);


//            if (hour < 0)
//            {
//                HourLabel.Text = "0";
//            }
//            if (sec < 0)
//            {
//                SecondsLabel.Text = "1";
//            }
//            try
//=======
//        private void StartButton_Click(object sender, RoutedEventArgs e)
//        {
//            _time = new TimeSpan(int.Parse(HourLabel.Text), int.Parse(SecondsLabel.Text), 0);
//            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
//>>>>>>> 6d3da202845b80438890718d3c4e3d2a735b17ba
//            {
//                _time = new TimeSpan(int.Parse(HourLabel.Text), int.Parse(SecondsLabel.Text), 0);

//<<<<<<< HEAD
//                _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
//                {
//                    TimeLeftLabel.Content = _time.ToString("c");
//                    if (_time == TimeSpan.Zero) _timer.Stop();
//                    _time = _time.Add(TimeSpan.FromSeconds(-1));
//                    _timer.Tick += _timer_Tick;
//                }, Application.Current.Dispatcher);


//                _timer.Start();
//            }
//            catch
//            {
//                HourLabel.Text = "0";
//                SecondsLabel.Text = "0";
//            }
//=======
//            _timer.Start();
//        }
//        private void PauseButton_Click(object sender, RoutedEventArgs e)
//        {
//            _timer.Stop();
//>>>>>>> 6d3da202845b80438890718d3c4e3d2a735b17ba
//        }

//        private void StopButton_Click(object sender, RoutedEventArgs e)
//        {
//            _timer.Stop();
//            TimeLeftLabel.Content = (_time - _time).ToString();
//            HourLabel.Text = "0";
//            SecondsLabel.Text = "0";
//        }

//<<<<<<< HEAD
//        private void HourUpButton_Click(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                int currentHourTime = int.Parse(HourLabel.Text);
//                currentHourTime++;
//                HourLabel.Text = currentHourTime.ToString();

//            }
//            catch
//            {
//                HourLabel.Text = "0";
//            }
//        }

//        private void HourDownButton_Click(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                int currentHourTime = int.Parse(HourLabel.Text);
//                if (currentHourTime != 0)
//                {
//                    currentHourTime--;
//                }
//                HourLabel.Text = currentHourTime.ToString();

//            }
//            catch
//            {
//                HourLabel.Text = "0";
//            }
//        }

//        private void SecondsUpButton_Click(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                int currentSecond = int.Parse(SecondsLabel.Text);
//                currentSecond++;
//                if (currentSecond > 59)
//                {
//                    HourUpButton_Click(sender, e);
//                    currentSecond = 0;
//                }
//                SecondsLabel.Text = currentSecond.ToString();
//            }
//            catch
//            {
//                SecondsLabel.Text = "0";
//            }
//        }

//        private void SecondsDownButton_Click(object sender, RoutedEventArgs e)
//        {
//            try
//            {
//                int currentSecond = int.Parse(SecondsLabel.Text);
//                if (currentSecond > 0)
//                {
//                    currentSecond--;
//                    if (currentSecond == 0)
//                    {
//                        currentSecond = 59;
//                        HourDownButton_Click(sender, e);
//                    }
//                    SecondsLabel.Text = currentSecond.ToString();
//                }
//            }
//            catch
//            {
//                SecondsLabel.Text = "0";
//            }
//=======
//        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)
//        {
//            main.Show();
//            this.Hide();
//        }

//        private void PantryMenuItem_Click(object sender, RoutedEventArgs e)
//        {
//            pantry.Show();
//            this.Hide();
//        }

//        private void ConversionChartMenuItem_Click(object sender, RoutedEventArgs e)
//        {
//            conversionChart.Show();
//            this.Hide();
//        }
//    }

=======

>>>>>>> origin/development
    public partial class Timer : Window
    {
        public MainWindow main;
        private DispatcherTimer _timer;
        TimeSpan _time;
        TimeSpan _default = new TimeSpan(0, 0, 0);
        private RecipeWindow recipeWindow;
        private PantryWindow pantry;
        private ConversionChart conversionChart;
        private Calendar calender;

        private void _timer_Tick(object sender, EventArgs e)
        {
            Duration duration = new Duration(TimeSpan.FromSeconds(20));

            //progress bar animation
            System.Windows.Media.Animation.DoubleAnimation doubleanimation = new System.Windows.Media.Animation.DoubleAnimation(200.0, duration);
            ProgressBar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
        }


        public Timer(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            pantry = new PantryWindow(mainWindow);
            conversionChart = new ConversionChart(mainWindow);
            calender = new Calendar(mainWindow);
            recipeWindow = new RecipeWindow(mainWindow);

        }

        public Timer(RecipeWindow recipeWindow)
        {
            this.recipeWindow = recipeWindow;
        }

<<<<<<< HEAD
        private void _timer_Tick(object sender, EventArgs e)
        {
            Duration duration = new Duration(TimeSpan.FromSeconds(20));

            //progress bar animation
            System.Windows.Media.Animation.DoubleAnimation doubleanimation = new System.Windows.Media.Animation.DoubleAnimation(200.0, duration);
            ProgressBar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
        }

       
=======
        private void homeButton_Clicked(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }

>>>>>>> origin/development


        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            int hour = int.Parse(HourLabel.Text);
            int sec = int.Parse(SecondsLabel.Text);


            if (hour < 0)
            {
                HourLabel.Text = "0";
            }
            if (sec < 0)
            {
                SecondsLabel.Text = "1";
            }
            try
            { 
                _time = new TimeSpan(int.Parse(HourLabel.Text), int.Parse(SecondsLabel.Text), 0);
                _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
                {
                    TimeLeftLabel.Content = _time.ToString("c");
                    if (_time == TimeSpan.Zero) _timer.Stop();
                    _time = _time.Add(TimeSpan.FromSeconds(-1));
                    _timer.Tick += _timer_Tick;
                }, Application.Current.Dispatcher);


                _timer.Start();
            }
            catch
            {
                HourLabel.Text = "0";
                SecondsLabel.Text = "0";
            }

            _timer.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            TimeLeftLabel.Content = (_time - _time).ToString();
            HourLabel.Text = "0";
            SecondsLabel.Text = "0";
        }

        private void HourUpButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int currentHourTime = int.Parse(HourLabel.Text);
                currentHourTime++;
                HourLabel.Text = currentHourTime.ToString();

            }
            catch
            {
                HourLabel.Text = "0";
            }
        }

        private void HourDownButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int currentHourTime = int.Parse(HourLabel.Text);
                if (currentHourTime != 0)
                {
                    currentHourTime--;
                }
                HourLabel.Text = currentHourTime.ToString();

            }
            catch
            {
                HourLabel.Text = "0";
            }
        }

        private void SecondsUpButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int currentSecond = int.Parse(SecondsLabel.Text);
                currentSecond++;
                if (currentSecond > 59)
                {
                    HourUpButton_Click(sender, e);
                    currentSecond = 0;
                }
                SecondsLabel.Text = currentSecond.ToString();
            }
            catch
            {
                SecondsLabel.Text = "0";
            }
        }

        private void SecondsDownButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int currentSecond = int.Parse(SecondsLabel.Text);
                if (currentSecond > 0)
                {
                    currentSecond--;
                    if (currentSecond == 0)
                    {
                        currentSecond = 59;
                        HourDownButton_Click(sender, e);
                    }
                    SecondsLabel.Text = currentSecond.ToString();
                }
            }
            catch
            {
                SecondsLabel.Text = "0";
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

        private void ConversionChartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            conversionChart.Show();
            this.Hide();
        }

        private void CalenderMenuItem_Click(object sender, RoutedEventArgs e)
        {
            calender.Show();
            this.Hide();
        }

        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as MenuItem).IsSubmenuOpen = true;
        }

        private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as MenuItem).IsSubmenuOpen = false;
        }

        private void RecipeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            recipeWindow.Show();
            this.Hide();
        }
    }

}
