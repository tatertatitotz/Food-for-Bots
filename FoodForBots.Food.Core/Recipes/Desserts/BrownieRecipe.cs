using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Ingredients.AnimalProduct;
using FoodForBots.Food.Core.Ingredients.Dessert;
using FoodForBots.Food.Core.Ingredients.Grains.Processed;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Desserts
{
    public class BrownieBatterRecipe : Recipe
    {
        public BrownieBatterRecipe()
        {
            AddRequirement<CocoaPowder>(1);
            AddRequirement<Butter>(1);
            AddRequirement<Flour>(1);
            AddRequirement<Sugar>(2);
            AddRequirement<Egg>(4);
        }
    }
    public class BrownieRecipe : Recipe
    {
        public BrownieRecipe()
        {
            AddRequirement<BrownieBatter>(1);  
            //Mayhaps add brownie varients like fudgy or cakey. Can be tied to the Baking process.
        }
    }
}
