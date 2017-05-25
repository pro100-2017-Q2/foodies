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
    enum Categories
    {
       Fruits, Vegetables, Protein, Dairy, Grains, Oils
    };
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
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; FieldChanged(); }
        }
        private string units;
        
        public Ingredients(string name, int fraction, string category, string units)
        {
            this.Name = name;
            this.WholeNumber = fraction;
            this.Category = category;
            this.Units = units;
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
    }
}
