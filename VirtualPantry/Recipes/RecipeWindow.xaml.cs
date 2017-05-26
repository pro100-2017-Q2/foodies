using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
﻿using System.Threading;
using System.Windows;
using VirtualPantry.Stretch;
using VirtualPantry.ThePantry;

namespace VirtualPantry.Recipes
{
    /// <summary>
    /// Interaction logic for Recipe.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public Stretch.Timer timer;
        public PantryWindow pantry;
        public RecipeWindow recipe;
        public ConversionChart conversionChart;
        public Stretch.Calendar calendar;
        public MainWindow main;
        private RecipeWindow recipeWindow;

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

        public RecipeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            timer = new Stretch.Timer(this);
			//pantry = new PantryWindow(this);
			recipe = new RecipeWindow(this);
            conversionChart = new ConversionChart(this);
            calendar = new Stretch.Calendar(this);
        }

        public RecipeWindow(RecipeWindow recipeWindow)
        {
            this.recipeWindow = recipeWindow;
        }

        private void homeButton_Clicked(object sender, RoutedEventArgs e)
        {
            main.Show();
            this.Hide();
        }

        //ImageSource i = new BitmapImage(new Uri("C:\\Users\\Sasuke-Joseph\\Desktop\foodies\\VirtualPantry\\Images\\cat.jpg"));

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
    }
}
