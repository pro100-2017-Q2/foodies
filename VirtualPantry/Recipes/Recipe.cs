using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VirtualPantry.Pantry;

namespace VirtualPantry.Recipes
{

	public class Recipe: INotifyPropertyChanged
	{
		private List<Ingredients> theIngredients;
		private string name;
		private StarRating rating;
		private int calories;
		private string instructions;

		public Recipe(List<Ingredients> theIngredients, string name, StarRating rating, int calories, string instructions)
		{
			this.theIngredients = theIngredients;
			this.name = name;
			this.rating = rating;
			this.calories = calories;
			this.instructions = instructions;
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
