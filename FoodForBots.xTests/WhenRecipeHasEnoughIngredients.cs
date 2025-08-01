using FoodForBots.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodForBots.Food.Core.Recipes.Entree;
using FoodForBots.Food.Core.Inventories;

namespace FoodForBots.xTests
{
    public class WhenRecipeHasEnoughIngredients
    {
        [Fact]
        public void ItCanMakeTheDish()
        {
            var chickenNuggetRecipe = new ChickenNuggetRecipe();
            var inventory = new ShopInventory();
            var canMake = chickenNuggetRecipe.CanMake(inventory);
            Assert.True(canMake);
        }
    }

}
