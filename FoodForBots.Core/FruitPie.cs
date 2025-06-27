using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodForBots.Core
{
    public class FruitPie : RecipeBestWay
    {
        public FruitPie() : base(new List<RecipeIngredient>()
        {new RecipeIngredient()
        })
        {

        }
        public bool CanMake(IngredientInventory inventory)
        {
            foreach (var i in Ingredients)
            {
                if (inventory.HasEnoughIngredients(i.Ingredient, i.Quantity))
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
