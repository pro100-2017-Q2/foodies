﻿using OverloadingOperators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using VirtualPantry.Enums;

namespace VirtualPantry.ThePantry
{
	/// <summary>
	/// Interaction logic for PantryWindow.xaml
	/// </summary>
	public partial class PantryWindow : Window
	{
		private MainWindow main;
		private Pantry p = new Pantry();

		static Fraction f = new Fraction(0, 2, 5);

		private static ObservableCollection<Ingredients> pantry = new ObservableCollection<Ingredients>
		{
			new Ingredients("Broccoli", 20, Categories.Vegetables, Units.lb),
		};

		public PantryWindow(MainWindow mainWindow)
		{
			InitializeComponent();
			main = mainWindow;

			PantryGrid.ItemsSource = pantry;
			CategoryComboBox.ItemsSource = Enum.GetValues(typeof(Categories));
			UnitsComboBox.ItemsSource = Enum.GetValues(typeof(Units));
		}
		private void homeButton_Clicked(object sender, RoutedEventArgs e)
		{
			main.Show();
			this.Hide();
		}
	}
}