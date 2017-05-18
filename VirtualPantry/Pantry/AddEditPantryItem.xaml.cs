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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VirtualPantry.Pantry
{
    /// <summary>
    /// Interaction logic for AddEditPantryItem.xaml
    /// </summary>
    public partial class AddEditPantryItem : Window
    {
        private Ingrediant tempIdent;
        List<String> PantryItems = new List<String>();
        public AddEditPantryItem()
        {
            InitializeComponent();
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AddPantryItemButton_Click(object sender, RoutedEventArgs e)
        {
            tempIdent.Name = Title.Text;
            tempIdent.WholeNumber = int.Parse(WholeNumber.Text);
            tempIdent.Numerator = int.Parse(Numerator.Text);
            tempIdent.Denominator = int.Parse(Denominator.Text);
            tempIdent.Category = Category.Text;
            tempIdent.Units = Units.Text;

            PantryItems.Add(tempIdent.ToString());

            String[] I = PantryItems.ToArray();
            System.IO.File.WriteAllLines("PantryItems", I);
        }
    }
}
