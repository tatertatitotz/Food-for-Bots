using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Dessert
{
    public class BrownieBatter : Ingredient
    {
        public BrownieBatter()
            : base(0)
        {
        }

        public BrownieBatter(int quantity)
            : base(quantity)
        {
        }
    }
}