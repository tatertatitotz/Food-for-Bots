using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.AnimalProduct;
using FoodForBots.Food.Core.Ingredients.Dessert;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Desserts
{
    public class MilkshakeRecipe : Recipe
    {
        public MilkshakeRecipe() 
        {
            AddRequirement<Icecream>(2);
            AddRequirement<Milk>(1);
            //Add blending function.
        }
    }
}
