using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.Fruit;
using FoodForBots.Food.Core.Ingredients.Meat;

namespace FoodForBots.BDD.Tests.RecipeIngredients
{
	public class WhenRecipeIngredientRequiresFruit
	{
		public class AndFruitIsUsed
		{
			[Fact]
			public void ThenItCounts()
			{
				var fruitIngredient = new RecipeIngredient<IFruit>(5);
				var isProperIngredient = fruitIngredient.IsIngredient(new Apple());

				Assert.True(isProperIngredient);
			}
		}

		public class AndMeatIsUsed
		{
			[Fact]
			public void ThenItDoesNotCount()
			{
				var fruitIngredient = new RecipeIngredient<IFruit>(5);
				var isProperIngredient = fruitIngredient.IsIngredient(new Chicken());

				Assert.False(isProperIngredient);
			}
		}
	}
}