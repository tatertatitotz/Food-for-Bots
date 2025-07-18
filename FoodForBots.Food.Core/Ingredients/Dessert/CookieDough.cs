using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.Dessert
{
    public class CookieDough : Ingredient
      
    {
        public CookieDough()
            : base(0)
        {

        }
        public CookieDough(int quantity)
            : base(quantity)
        {

        }
    }

    public class ChocolateChipCookieDough : Ingredient
    {
        public ChocolateChipCookieDough()
            : base(0)
        {

        }
        public ChocolateChipCookieDough(int quantity)
            : base(quantity)
        {

        }
    }
}