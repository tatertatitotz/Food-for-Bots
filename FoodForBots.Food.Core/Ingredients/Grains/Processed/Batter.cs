using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Grains.Processed
{
    public class Batter : Ingredient
    {
        public Batter()
      : base(0)
        {

        }
        public Batter(int quantity)
            : base(quantity)
        {

        }
    }
}
