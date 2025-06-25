using System;
using System.Collections.Generic;

namespace FoodForBots.Core
{
    public class RecipeTheWrongWay
    {
        public string Name { get; set; } = "AnyOldTextInHere1";
        public object Inputs { get; set; }
        public object Output { get; set; }

    }
    public class RecipeBetterWay
    {
        public string Name { get; set; } = "AnyOldTextInHere2";
        public List<Ingredient> Ingredients { get; set; }
        public Dish Dish { get; set; }
    }
    public class Ingredient
    {
        public string Name { get; set; }

    }
    public class Dish
    {
        public string Name { get; set; }

    }
    public class RecipeBestWay
    {
        public string Name { get; set; } = "AnyOldTextInHere3";
        private readonly List<Ingredient> ingredients;
        public IEnumerable<Ingredient> Ingredients => ingredients;
        public Dish Dish { get; set; }
    }
}
