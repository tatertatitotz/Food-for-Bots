using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Grains.Processed
{
    public class Flour : Ingredient
    {
        public Flour()
    : base(0)
        {

        }
        public Flour(int quantity)
            : base(quantity)
        {

        }
    }
}
