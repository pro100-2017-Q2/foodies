using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VirtualPantry.Recipes
{
	/// <summary>
	/// Interaction logic for Recipe.xaml
	/// </summary>
	public partial class RecipeWindow : Window
	{
		public MainWindow main;

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
		}

		private void homeButton_Clicked(object sender, RoutedEventArgs e)
		{
			main.Show();
			this.Hide();
		}

		private void NavigationBar_Click(object sender, RoutedEventArgs e)
		{

		}

        //ImageSource i = new BitmapImage(new Uri("C:\\Users\\Sasuke-Joseph\\Desktop\foodies\\VirtualPantry\\Images\\cat.jpg"));

	}
}
