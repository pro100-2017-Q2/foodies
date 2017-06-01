using System;
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
using VirtualPantry.Enums;
using VirtualPantry.ThePantry;

namespace VirtualPantry.Recipes
{
    /// <summary>
    /// Interaction logic for IndividualRecipe.xaml
    /// </summary>
    public partial class IndividualRecipe : Window
    {
        string recipeName;
        string instructions;
        int calories;
        List<Ingredients> ingredients;
        StarRating ratingSelected;
        public IndividualRecipe()
        {
            InitializeComponent();
            IngredientsDataGrid.ItemsSource = ingredients;
        }
        private void RecipeNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            recipeName = RecipeNameTextBox.Text;
        }
        private void CalorieTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           // calories = int.Parse(CalorieTextBox.Text);
        }
        private void InstructionsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            instructions = InstructionsTextBox.Text;
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            new Recipe(recipeName, instructions, calories, ingredients, ratingSelected);
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            tbx.Text = string.Empty;
            tbx.GotFocus -= TextBox_GotFocus;
        }
    }
}