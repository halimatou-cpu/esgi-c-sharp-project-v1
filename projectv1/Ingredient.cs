using System;
namespace projectv1
{
	public class Ingredient
	{
		private string name;
		private double quantity;
		private string unit = null; // kg/g or nothing

		public Ingredient(string name, double quantity, string unit)
		{
			this.name = name;
			this.quantity = quantity;
			this.unit = unit;
		}

		public Ingredient(string name, double quantity)
		{
			this.name = name;
			this.quantity = quantity;
		}

		public void setUnit(string unit)
        {
			this.unit = unit;
        }

		override
		public string ToString()
        {
			string giventUnit = unit != null ? ($"{unit} de ") : "";
			return $"{quantity}{giventUnit} {name}";
		}
	}
}

