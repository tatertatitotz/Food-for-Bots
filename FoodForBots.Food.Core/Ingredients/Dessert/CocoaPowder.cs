using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Dessert
{
    public class CocoaPowder : Ingredient
    {
        public CocoaPowder()
    : base(0)
        {

        }
        public CocoaPowder(int quantity)
            : base(quantity)
        {

        }
    }
}
