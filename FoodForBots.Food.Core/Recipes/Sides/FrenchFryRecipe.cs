using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.Vegetable;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Sides
{
    public class FrenchFryRecipe : Recipe
    {
        public FrenchFryRecipe() 
        {
            AddRequirement<Potato>(1);
            //Add Fryer function.
        }
    }
}
