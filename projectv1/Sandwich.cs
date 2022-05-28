using System;
namespace projectv1
{
	public class Sandwich
	{
		private string Name;
		public Ingredient[] ingredients;
		private double Price;

		public Sandwich(string name,Ingredient[] ingredients, double price)
		{
			Name = name;
			this.ingredients = ingredients;
			Price = price;
		}
	}
}

