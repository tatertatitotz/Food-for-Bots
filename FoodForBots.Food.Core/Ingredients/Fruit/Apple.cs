using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.Fruit
{
	public class Apple : Ingredient, IFruit
	{
        public Apple()
        : base(0)
        {

        }
        public Apple(int quantity)
            : base(quantity)
        {

        }
    }
}