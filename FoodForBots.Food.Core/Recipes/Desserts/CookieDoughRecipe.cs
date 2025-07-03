using FoodForBots.Contracts.Ingredients;
using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.AnimalProduct;
using FoodForBots.Food.Core.Ingredients.Dessert;
using FoodForBots.Food.Core.Ingredients.Fruit;
using FoodForBots.Food.Core.Ingredients.Grains.Processed;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Desserts
{
    public class CookieDoughRecipe : Recipe, IIngredient
    {
        public CookieDoughRecipe() 
        {
            AddRequirement<Butter>(2);
            AddRequirement<Flour>(5);
            AddRequirement<Sugar>(2);
            AddRequirement<Egg>(1);
        }
    }
    public class ChocolateChipCookieDoughRecipe : Recipe
    {
        public ChocolateChipCookieDoughRecipe()
        {
            AddRequirement<CookieDough>(1);
            AddRequirement<ChocolateChip>(1);
        }
    }
}
