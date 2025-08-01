using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Vegetable
{
    public class Potato : Ingredient, IVegetable
    {
        public Potato()
               : base(0)
        {

        }
        public Potato(int quantity)
            : base(quantity)
        {

        }
    }
}
