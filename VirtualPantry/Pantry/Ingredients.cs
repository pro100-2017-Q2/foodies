using OverloadingOperators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VirtualPantry.Enums;

namespace VirtualPantry.Pantry
{
    public class Ingredients
    {
        public Ingredients(Categories categories, string name, List<string> fractions, int wholeNumber, Units units)
        {
            Categories = categories;
            Name = name;
            Fractions = fractions;
            WholeNumber = wholeNumber;
            Units = units;
        }
        public Ingredients(){ }
        public Categories Categories { get; set; }
        public string Name { get; set; }
        public List<string> Fractions { get; set; }
        public int WholeNumber { get; set; }
        public Units Units { get; set; }

    }
}
