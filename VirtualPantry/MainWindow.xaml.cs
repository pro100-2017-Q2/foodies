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

namespace VirtualPantry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Stretch.Timer timer = new Stretch.Timer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            mainNavigationFrame.Navigate(timer);
            this.Show();
        }
        private void Navigation(Window window)
        {
           
        }
    }
}