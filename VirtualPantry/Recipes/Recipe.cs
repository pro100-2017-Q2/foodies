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
		private List<Ingredients> theIngredients;
		private string name;
		private StarRating rating;
		private int calories;
		private string instructions;

		public Recipe(List<Ingredients> theIngredients, string name, StarRating rating, int calories, string instructions)
		{
			TheIngredients = theIngredients;
			Name = name;
			Rating = rating;
			Calories = calories;
			Instructions = instructions;
		}

		public List<Ingredients> TheIngredients
		{
			get { return theIngredients; }
			set { theIngredients = value; FieldChanged(); }
		}
		public string Name
		{
			get { return name; }
			set { name = value; FieldChanged(); }
		}
		public StarRating Rating
		{
			get { return rating; }
			set { rating = value; FieldChanged(); }
		}
		public int Calories
		{
			get { return calories; }
			set { calories = value; FieldChanged(); }
		}
		public string Instructions
		{
			get { return instructions; }
			set { instructions = value; FieldChanged(); }
		}
		public override string ToString()
		{
			string strIngredients = "";
			foreach (Ingredients i in theIngredients)
			{
				strIngredients += i.Name + ", ";
			}
			return $"{name}, Ingredients: {strIngredients}\nCalories: {Calories}, Rating: {rating}\nInstructions: {instructions}";
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void FieldChanged([CallerMemberName] string field = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(field));
			}
		}
	}
}
