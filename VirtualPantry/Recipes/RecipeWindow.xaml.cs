﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
﻿using System.Threading;
using VirtualPantry.Stretch;
using System.Windows.Controls;
using VirtualPantry.ThePantry;

namespace VirtualPantry.Recipes
{
    /// <summary>
    /// Interaction logic for Recipe.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
       
        public MainWindow main;
        private Stretch.Timer timer;
        private PantryWindow pantry;
        private ConversionChart conversionChart;
        private Stretch.Calendar calendar;

        public RecipeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            timer = new Stretch.Timer(mainWindow);
            pantry = new PantryWindow(mainWindow);
            conversionChart = new ConversionChart(mainWindow);
            calendar = new Stretch.Calendar(mainWindow);
        }

        public string FileText
        {
            get
            {
                return FileText;
            }
            set
            {
                FileText = value;
                return;
            }
        }

        public object RecipeListing
        {
            get
            {
                return RecipeListing;
            }
            set
            {
                RecipeListing = value;
                return;
            }
        }

        public void ReadFile(string path)
        {
            RecipeListing = path;
        }

        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as MenuItem).IsSubmenuOpen = true;
        }

        private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            (sender as MenuItem).IsSubmenuOpen = false;
        }

        private void TimerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            timer.Show();
            this.Hide();
        }


        private void NavigationBar_Click(object sender, RoutedEventArgs e)
        {

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

        private void CalendarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            calendar.Show();
            this.Hide();
        }

        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }


        //ImageSource i = new BitmapImage(new Uri("C:\\Users\\Sasuke-Joseph\\Desktop\foodies\\VirtualPantry\\Images\\cat.jpg"));




        //ImageSource i = new BitmapImage(new Uri("C:\\Users\\Sasuke-Joseph\\Desktop\foodies\\VirtualPantry\\Images\\cat.jpg"));


    }
}
