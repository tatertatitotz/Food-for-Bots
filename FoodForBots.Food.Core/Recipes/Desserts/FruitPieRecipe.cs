using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.Fruit;

namespace FoodForBots.Food.Core.Recipes.Desserts
{
	public class FruitPieRecipe : Recipe
	{
		public FruitPieRecipe()
		{
			AddRequirement<IFruit>(2);
		}
	}
}