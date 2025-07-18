using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Grains.Processed
{
    public class ChocolateChip : Ingredient
    {
        public ChocolateChip()
        : base(0)
        {

        }
        public ChocolateChip(int quantity)
            : base(quantity)
        {

        }
    }
}
