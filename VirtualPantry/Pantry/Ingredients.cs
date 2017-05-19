using OverloadingOperators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPantry.Pantry
{
    enum FoodCategories {Fruits, Vegetables, Protein, Dairy, Grains, Oils};
    class Ingredients : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; FieldChanged(); }
        }

        private int wholeNumber;

        public int WholeNumber
        {
            get { return wholeNumber; }
            set { wholeNumber = value; FieldChanged(); }
        }

        private int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; FieldChanged(); }
        }

        private int denominator;

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; FieldChanged(); }
        }


        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; FieldChanged(); }
        }

        private string units;
        
        public Ingredients(string n, int whole, string category, string units, int num = 0, int den = 0)
        {
            Name = n;
            WholeNumber = whole;
            Category = category;
            Numerator = num;
            Denominator = den;
            Units = units;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Units
        {
            get { return units; }
            set { units = value; FieldChanged(); }
        }


        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }

        public override string ToString()
        {
			Fraction f = new Fraction(WholeNumber, Numerator, Denominator);
			f.MakeImProper();
			return $"{Name} {Category} {f} {Units}";
        }


    }
}
