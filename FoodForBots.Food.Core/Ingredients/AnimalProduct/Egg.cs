using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.AnimalProduct
{
    public class Egg : Ingredient
    {
        public Egg()
         : base(0)
        {

        }
        public Egg(int quantity)
            : base(quantity)
        {

        }
    }
}