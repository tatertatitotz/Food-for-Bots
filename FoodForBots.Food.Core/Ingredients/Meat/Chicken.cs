using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.Meat
{
	public class Chicken : Ingredient, IMeat
	{
        public Chicken()
               : base(0)
        {

        }
        public Chicken(int quantity)
            : base(quantity)
        {

        }
    }
}