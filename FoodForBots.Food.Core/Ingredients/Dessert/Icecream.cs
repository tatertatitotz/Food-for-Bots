using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Dessert
{
    public class Icecream : Ingredient, IMenuItem
    {
        public Icecream()
            : base(0)
        {
        }

        public Icecream(int quantity)
            : base(quantity)
        {
        }
    }
}