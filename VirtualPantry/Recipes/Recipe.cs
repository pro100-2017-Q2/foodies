using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VirtualPantry.ThePantry;

namespace VirtualPantry.Recipes
{
    public class Recipe
    { 
        public Recipe(string recipeName, string instructions, int calories, List<Ingredients> ingredients, StarRating ratingSelected)
        {
            RecipeName = recipeName;
            Instructions = instructions;
            Calories = calories;
            Ingredients = ingredients;
            RatingSelected = ratingSelected;
        }
        public Recipe() { }
        public string RecipeName { get; set; }
        public string Instructions { get; set; }
        public int Calories { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public StarRating RatingSelected { get; set; }
        public void WriteToFile(string recipeName)
        {
            // Takes in data user gave via IndividualRecipe Window and writes it all to file.
        }
        public void ReadFromFile(string filename)
        {
            // Reads data from specific file and displays to RecipeWindow.
        }
        public void RemoveRecipe()
        {
            // IDK yet !
        }
        public void EditRecipe()
        {
            // IDK yet !
        }
    }
}
