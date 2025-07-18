using FoodForBots.Contracts.Ingredients;
using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.Fruit;
using FoodForBots.Food.Core.Ingredients.Meat;
using FoodForBots.Food.Core.Inventories;
using FoodForBots.Food.Core.Recipes.Desserts;
using Moq;

namespace FoodForBots.BDD.Tests.RecipeIngredients
{
    public class WhenMakingCookies
    {
        public class AndAllTheIngredientsAreAvailable
        {
            [Fact]
            public void ThenItBakes()
            {
                var cookieRecipe = new CookieRecipe();
                var maker = new RecipeMaker<CookieRecipe>(new ShopInventory());

                var canMake = maker.StartMaking(cookieRecipe);
                var cookies = maker.FinishMaking(cookieRecipe);
                Assert.True(canMake);
                Assert.Equal(12, cookies.First().Quantity);
            }
        }

        public class AndSomeIngredientsAreAvailable
        {
            [Fact]
            public void ThenItDoesNotBake()
            {
                var fruitIngredient = new RecipeIngredient<IFruit>(5);
                var isProperIngredient = fruitIngredient.IsIngredient(new Chicken());

                Assert.False(isProperIngredient);
            }
        }
    }
}