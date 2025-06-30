using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;

namespace FoodForBots.Contracts.Recipes
{
	public abstract class Recipe
	{
		//protected Dictionary<Type, string> requirements = 
		protected readonly List<IRecipeIngredient> ingredients = new List<IRecipeIngredient>();
		public string DisplayName { get; protected set; } = string.Empty;
		public IEnumerable<IRecipeIngredient> Ingredients => ingredients;

		protected void AddRequirement<TIngredient>(int quantity)
			where TIngredient : IIngredient
		{
			ingredients.Add(new RecipeIngredient<TIngredient>(quantity));
		}
	}
}