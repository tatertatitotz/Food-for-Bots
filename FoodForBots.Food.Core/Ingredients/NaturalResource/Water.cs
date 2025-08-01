using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.NaturalResource
{
    public class Water : Ingredient, IMenuItem
    {
        public Water()
             : base(0)
        {

        }
        public Water(int quantity)
            : base(quantity)
        {

        }
    }
}
