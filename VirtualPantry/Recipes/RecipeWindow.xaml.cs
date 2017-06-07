using System;
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
        

        public RecipeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private void NewRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            main.ir.Show();
            // New IndividualRecipe Window pops up and user inputs data, data inputted is written to new file when they click save.
        }
        private void EditRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Make new IndividualRecipe Window pop up that displays recipe that was selected.
            // Changes by removing selected recipe's file and re-creating it.
        }
        private void RemoveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Removes whatever recipe user selected. IDK if it should be a pop up yet. 
            //Basically removes file by taking in name of recipe.
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
            main.timer.Show();
            this.Hide();
        }

        private void PantryMenuItem_Click(object sender, RoutedEventArgs e)
        {
            main.pantry.Show();
            this.Hide();
        }

        private void ConversionChartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            main.conversionChart.Show();
            this.Hide();
        }

        private void CalendarMenuItem_Click(object sender, RoutedEventArgs e)
        {
            main.calendar.Show();
            this.Hide();
        }

        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)

        {
            main.Show();
            this.Hide();
        }
    }
} 