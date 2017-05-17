using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPantry.Pantry
{
    enum FoodCategories {Fruits, Vegetables, Protein, Dairy, Grains, Oils};
    class Ingrediant
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int wholeNumberQuantity;

        public int WholeNumberQuantity 
        {
            get { return wholeNumberQuantity; }
            set { wholeNumberQuantity = value; }
        }

        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denominator;

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }


        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string units;

        public string Units
        {
            get { return units; }
            set { units = value; }
        }


        public override string ToString()
        {
            return Name + " " + Category + " " + WholeNumberQuantity + " " + Numerator + " " + Denominator + " " + Units;
        }


    }
}
