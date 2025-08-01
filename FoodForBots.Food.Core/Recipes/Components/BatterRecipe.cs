using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.Grains.Processed;
using FoodForBots.Food.Core.Ingredients.NaturalResource;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Components
{
    //Components is the temp name for Ingredients used in other recipes that require their own designated Recipe.
    public class BatterRecipe : Recipe
    {
        public BatterRecipe()
        {
            AddRequirement<CornStarch>(1);
            AddRequirement<Flour>(1);
            AddRequirement<Water>(1);
        }
    }
}
