using FoodForBots.Contracts.Ingredients;
using FoodForBots.Contracts.Recipes;
using FoodForBots.Food.Core.Equipment.HeatAppliers;
using FoodForBots.Food.Core.Equipment.HeatUtensils;
using FoodForBots.Food.Core.Ingredients.AnimalProduct;
using FoodForBots.Food.Core.Ingredients.Dessert;
using FoodForBots.Food.Core.Ingredients.Fruit;
using FoodForBots.Food.Core.Ingredients.Grains.Processed;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Recipes.Desserts
{
    public class ChocolateChipCookieDoughRecipe : Recipe
    {
        public ChocolateChipCookieDoughRecipe()
        {
            AddRequirement<CookieDough>(1);
            AddRequirement<ChocolateChip>(1);
            AddOutput<ChocolateChipCookieDough>(1);
        }
    }

    public class CookieDoughRecipe : Recipe, IIngredient
    {
        public CookieDoughRecipe()
        {
            AddRequirement<Butter>(2);
            AddRequirement<Flour>(5);
            AddRequirement<Sugar>(2);
            AddRequirement<Egg>(1);
            AddOutput<CookieDough>(1);
        }
    }
    public class CookieRecipe : Recipe
    {
        public CookieRecipe()
        {
            AddRequirement<CookieDough>(1);
            AddRequirement<BakingTray, DefaultSetting>(1, new DefaultSetting());
            AddRequirement<Oven, OvenSetting>(1, new OvenSetting() {Fahrenheit = 350, HeatingSeconds = 60*12});
            AddOutput<Cookie>(12);
        }
    }
    public class ChocolateChipCookieRecipe : Recipe
    {
        public ChocolateChipCookieRecipe()
        {
            AddRequirement<ChocolateChipCookieDough>(1);
            AddRequirement<BakingTray, DefaultSetting>(1, new DefaultSetting());
            AddRequirement<Oven, OvenSetting>(1, new OvenSetting() { Fahrenheit = 350, HeatingSeconds = 60 * 12 });
            AddOutput<ChocolateChipCookie>(12);
        }
    }
}
