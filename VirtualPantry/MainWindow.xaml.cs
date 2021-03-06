﻿using System;
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
using VirtualPantry.ThePantry;
using VirtualPantry.Recipes;
using VirtualPantry.Stretch;

namespace VirtualPantry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
     {                
        public Stretch.Timer timer;
        public PantryWindow pantry;
        public RecipeWindow recipe;
        public ConversionChart conversionChart;
        public Stretch.Calendar calendar;
        public IndividualRecipe ir;
        public MainWindow()
        {
            InitializeComponent();
            timer = new Timer(this);
            pantry = new PantryWindow(this);
            recipe = new RecipeWindow(this);
            conversionChart = new ConversionChart(this);
            calendar = new Stretch.Calendar(this);
            ir = new IndividualRecipe();
        }
        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Show();
            this.Hide();
        }
        private void PantryButton_Click(object sender, RoutedEventArgs e)
        {
            pantry.Show();
            this.Hide();
        }
        private void Recipes_Click(object sender, RoutedEventArgs e)
        {
            recipe.Show();
            this.Hide();
        }
        private void ConversionChart_Click(object sender, RoutedEventArgs e)
        {
            conversionChart.Show();
            this.Hide();
        }
        private void CalendarButton_Click(object sender, RoutedEventArgs e)
        {
            calendar.Show();
            this.Hide();
        }
    }
}