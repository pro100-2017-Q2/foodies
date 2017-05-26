﻿using OverloadingOperators;
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

	public class Ingredients : INotifyPropertyChanged
	{
		private string name;
		private int wholeNumber;
		private Categories category;
		private Units ingredientUnits;

		public string Name
		{
			get { return name; }
			set { name = value; FieldChanged(); }
		}
		public int WholeNumber
		{
			get { return wholeNumber; }
			set { wholeNumber = value; FieldChanged(); }
		}
		public Categories Category
		{
			get { return category; }
			set { category = value; FieldChanged(); }
		}
		public Units IngredientUnits
		{
			get { return ingredientUnits; }
			set { ingredientUnits = value; FieldChanged(); }
		}
		public Ingredients(string name, int wholeNumber, Categories category, Units units)
		{
			this.Name = name;
			this.WholeNumber = wholeNumber;
			this.Category = category;
			this.IngredientUnits = units;
		}
		public Ingredients()
		{

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