using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.AnimalProduct;
using FoodForBots.Food.Core.Ingredients.Dessert;
using FoodForBots.Food.Core.Ingredients.Grains.Processed;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Desserts
{
    public class CakeBatterRecipe : Recipe
    {
        public CakeBatterRecipe() 
        {
            AddRequirement<Butter>(2);
            AddRequirement<Flour>(5);
            AddRequirement<Sugar>(4);
            AddRequirement<Egg>(1);
        }
    }
    public class ChocolateChipCakeBatterRecipe : Recipe
    {
        public ChocolateChipCakeBatterRecipe()
        {
            AddRequirement<CakeBatter>(1);
            AddRequirement<ChocolateChip>(1);
        }
    }
    public class CakeRecipe : Recipe
    {
        public CakeRecipe()
        {
            AddRequirement<CakeBatter>(1);
        }
    }
}
