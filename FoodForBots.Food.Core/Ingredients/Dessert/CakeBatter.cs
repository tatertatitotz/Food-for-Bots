using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.Dessert
{
    public class CakeBatter : Ingredient
    {
        public CakeBatter()
         : base(0)
        {

        }
        public CakeBatter(int quantity)
            : base(quantity)
        {

        }
    }
}