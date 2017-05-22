using System;
using System.Collections.Generic;
using System.IO;
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


        private Ingredients tempIdent;

        private PantryWindow pantry;

        List<String> PantryItems = new List<String>();
        public AddEditPantryItem(PantryWindow pantryWindow)
        {
            InitializeComponent();
            pantry = pantryWindow;
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AddPantryItemButton_Click(object sender, RoutedEventArgs e)
        {
            tempIdent = new Ingredients(Title.Text, int.Parse(WholeNumber.Text), Category.Text, Units.Text, int.Parse(Numerator.Text), int.Parse(Denominator.Text));

  

            PantryItems.Add(tempIdent.ToString());

            String[] I = PantryItems.ToArray();
            string pathToDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(pathToDocuments + @"\PantryItems.txt"))
                foreach (string item in I)
                    outputFile.WriteLine(item);
        }
<<<<<<< HEAD
        private void ReadFromFile()
        {
            
        }

=======
>>>>>>> origin/development

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
<<<<<<< HEAD

=======
>>>>>>> origin/development
    }
}
