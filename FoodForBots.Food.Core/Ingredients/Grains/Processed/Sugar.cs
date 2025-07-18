using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Grains.Processed
{
    public class Sugar : Ingredient
    {
        public Sugar()
       : base(0)
        {

        }
        public Sugar(int quantity)
            : base(quantity)
        {

        }
    }
}
