using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.AnimalProduct
{
    public class Milk : Ingredient, IMenuItem
    {
        public Milk()
         : base(0)
        {

        }
        public Milk(int quantity)
            : base(quantity)
        {

        }

    }
}
