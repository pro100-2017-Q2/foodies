using OverloadingOperators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VirtualPantry.Enums;

namespace VirtualPantry.ThePantry
{

    public class Ingredients
    {

        public Ingredients(string name, string wholeNumber, List<string> fractions, Categories categories, Units units)
        {
            Name = name;
            WholeNumber = wholeNumber;
            Fractions = fractions;
            Categories = categories;
            Units = units;
        }
        public Ingredients() { }
        public string Name { get; set; }
        public string WholeNumber { get; set; }
        public List<string> Fractions { get; set; }
        public Categories Categories { get; set; }
        public Units Units { get; set; }
    }  
}
