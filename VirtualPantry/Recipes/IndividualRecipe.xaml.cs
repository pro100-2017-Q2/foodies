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
        public IndividualRecipe(Recipe r)
        {
			if (r == null)
			{
				List<Ingredients> l = new List<Ingredients> { };
				r = new Recipe(l, "", StarRating.zero, 0, "");
			}
            InitializeComponent();
			ThePanel.DataContext = r;
			IngredientsListBox.ItemsSource = r.TheIngredients;
        }
    }
}
