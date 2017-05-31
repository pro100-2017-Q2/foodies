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
<<<<<<< HEAD
        List<string> fractions = new List<string>();
        public IndividualRecipe()
=======
        public IndividualRecipe(Recipe r)
>>>>>>> origin/development
        {
			if (r == null)
			{
<<<<<<< HEAD
				new Ingredients("Broccoli", " ", fractions, Categories.Vegetables, Units.lb)
			};
			string ipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In et tristique ligula. Fusce eget eros finibus, gravida enim a, dapibus purus. Morbi dictum maximus mauris non semper. Maecenas vitae pretium leo. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aenean blandit augue lectus, eget faucibus dui aliquet eu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin pellentesque porttitor nisi a volutpat. Fusce et purus tincidunt, lacinia metus in, hendrerit lacus. Phasellus malesuada scelerisque ullamcorper. Maecenas dapibus ipsum sed nunc blandit, sed gravida ante tempus. Maecenas blandit lacus sed felis fringilla cursus.Curabitur leo augue, pharetra et felis at, sollicitudin feugiat tortor. Phasellus porttitor rhoncus sapien, id lobortis libero dictum quis. Sed sed sollicitudin metus. Nulla faucibus lectus vitae lectus aliquam malesuada.Vivamus ac tortor sem. Integer luctus a purus sed imperdiet. Ut varius cursus mauris a dapibus. Suspendisse orci leo, tempus vel rhoncus at, iaculis sed urna. Nullam eu est justo. Pellentesque imperdiet maximus eros, in tincidunt libero lobortis nec. In hac habitasse platea dictumst.Suspendisse porta felis vitae consequat vestibulum. Vestibulum eget vulputate enim. Mauris rhoncus mi tempus, aliquam libero a, ultrices velit.Donec at nisi volutpat, placerat neque ut, venenatis erat. Nullam viverra elit et lectus posuere ullamcorper.Morbi imperdiet ante vitae ex efficitur venenatis.Pellentesque quis scelerisque elit. Donec et consequat urna. Sed id eros vitae est malesuada porta.Maecenas nibh tortor, tincidunt id mollis quis, lobortis quis tortor. Nulla nec nunc quis est lobortis facilisis.Nam convallis enim aliquet ex volutpat, nec gravida ex sagittis.Integer placerat, arcu ultricies dignissim pulvinar, ligula nisl accumsan augue, sit amet consequat lacus tellus eu lacus. Aliquam non porttitor risus. Suspendisse fermentum tristique sapien sed semper. Fusce aliquet nisl neque, eu tincidunt dui tincidunt a. Etiam sodales, nunc nec rhoncus convallis, nisi velit tristique tellus, ac aliquet elit dolor ut lacus. Morbi ultrices urna non malesuada vulputate. Vestibulum pretium felis eget sapien accumsan ornare.Etiam sapien sapien, lacinia et varius ac, egestas in orci.Nulla felis nulla, viverra eu leo finibus, fringilla rutrum nisl. Curabitur ultricies ornare aliquam. Suspendisse mauris ex, faucibus vitae imperdiet quis, imperdiet sit amet lectus.Duis convallis ipsum quis turpis mattis gravida.Ut venenatis massa erat, ac faucibus odio malesuada sit amet.Fusce a pulvinar ipsum. Aliquam in lacus ultricies, rutrum arcu sit amet, varius lectus. Mauris vel dui sagittis, eleifend elit eu, feugiat lacus.Vivamus nibh nunc, pulvinar ac porta vel, vulputate et elit. Nunc rutrum mi a lorem suscipit consectetur. Sed id rutrum arcu, scelerisque venenatis sapien. Suspendisse bibendum tempus ipsum a hendrerit. Nulla pulvinar in dui non facilisis.Vestibulum at mollis ante, eget ornare magna. Pellentesque quis sollicitudin risus, eu dictum urna. Phasellus tincidunt suscipit orci, vel dapibus lorem maximus sit amet.Vivamus sollicitudin nisi ac auctor commodo. Sed et leo leo. Ut condimentum egestas nisi, at convallis est volutpat eget. Morbi euismod, nulla at commodo accumsan, mi libero convallis quam, id varius augue nisl ut orci.Proin congue lacinia mauris ut sagittis. Nullam ac dolor ut est dictum imperdiet nec vitae mi. Maecenas aliquet dui vel nisl pharetra vestibulum.";
			Recipe r = new Recipe(i, "chicken parmesean I guess", StarRating.four, 750, ipsum);
#endregion
=======
				List<Ingredients> l = new List<Ingredients> { };
				r = new Recipe(l, "", StarRating.zero, 0, "");
			}
            InitializeComponent();
>>>>>>> origin/development
			ThePanel.DataContext = r;
			IngredientsListBox.ItemsSource = r.TheIngredients;
        }
    }
}
