using FoodForBots.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForBots.xTests
{
    public class WhenRecipeHasEnoughIngredients
    {
        [Fact]
        public void ItCanMakeTheDish()
        {
            var pieRecipe = new FruitPie();
            var inventory = new IngredientInventory();
            var canMake = pieRecipe.CanMake(inventory);
            Assert.True(canMake);
        }
        [Fact]
        public void QuickTest()
        {
            var apple1 = new Apple();
            var apple2 = new Apple();
            var apple3 = apple1;
            Assert.Equal(apple1, apple3);
        }
    }

}
