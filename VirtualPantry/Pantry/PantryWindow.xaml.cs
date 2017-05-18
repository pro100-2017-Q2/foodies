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
using System.Windows.Shapes;
using VirtualPantry;
using VirtualPantry.Pantry;

namespace ProVirtualPantry.Pantry
{
    /// <summary>
    /// Interaction logic for PantryWindow.xaml
    /// </summary>
    public partial class PantryWindow : Window
    {
        private MainWindow main;
        private AddEditPantryItem itemPage;
        public PantryWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }
        private void addAnIngredientButton_Clicked(object sender, RoutedEventArgs e)
        {
            itemPage.Show();
        }
    }
}
