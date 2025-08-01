using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.Grains.Processed;
using FoodForBots.Food.Core.Ingredients.Meat;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Entree
{
    public class ChickenNuggetRecipe : Recipe
    {
        public ChickenNuggetRecipe()
        {
            AddRequirement<Chicken>(1);
            AddRequirement<Batter>(1);
            //AddRequirement<ChickenBits>(1); ?
        }
    }

}
