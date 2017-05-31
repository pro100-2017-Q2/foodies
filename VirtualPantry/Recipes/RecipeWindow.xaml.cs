using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
﻿using System.Threading;
using VirtualPantry.Stretch;
using System.Windows.Controls;
using VirtualPantry.ThePantry;
<<<<<<< HEAD

=======
>>>>>>> origin/development

namespace VirtualPantry.Recipes
{
    /// <summary>
    /// Interaction logic for Recipe.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
       
        public MainWindow main;
        private Stretch.Timer timer;

        public RecipeWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            timer = new Stretch.Timer(mainWindow);
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

<<<<<<< HEAD
=======

>>>>>>> origin/development
        private void homeButton_Clicked(object sender, RoutedEventArgs e)
        {
            main.Show();
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

        private void TimerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            timer.Show();
            this.Hide();
        }

        private void NavigationBar_Click(object sender, RoutedEventArgs e)
        {

        }
<<<<<<< HEAD
=======

        //ImageSource i = new BitmapImage(new Uri("C:\\Users\\Sasuke-Joseph\\Desktop\foodies\\VirtualPantry\\Images\\cat.jpg"));



        //ImageSource i = new BitmapImage(new Uri("C:\\Users\\Sasuke-Joseph\\Desktop\foodies\\VirtualPantry\\Images\\cat.jpg"));

>>>>>>> origin/development
    }
}
