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

namespace VirtualPantry.Recipes
{
    /// <summary>
    /// Interaction logic for AddEditRecipe.xaml
    /// </summary>
    public partial class AddEditRecipe : Window
    {
        public AddEditRecipe()
        {
            InitializeComponent();
        }

        private void cancelButon_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
