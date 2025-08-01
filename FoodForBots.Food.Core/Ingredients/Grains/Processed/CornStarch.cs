using FoodForBots.Contracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Ingredients.Grains.Processed
{
    public class CornStarch : Ingredient
    {
        public CornStarch()
        : base(0)
        {

        }
        public CornStarch(int quantity)
            : base(quantity)
        {

        }
    }
}

