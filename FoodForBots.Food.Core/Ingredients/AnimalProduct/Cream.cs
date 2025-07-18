using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.AnimalProduct
{
    public class Cream : Ingredient
    {
        public Cream()
         : base(0)
        {

        }
        public Cream(int quantity)
            : base(quantity)
        {

        }
    }
}