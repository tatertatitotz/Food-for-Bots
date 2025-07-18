using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Contracts.Ingredients
{
    public class NoIngredient : IIngredient
    {
        public int Quantity => 0;
    }
}
