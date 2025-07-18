using FoodForBots.Contracts.Ingredients;

namespace FoodForBots.Food.Core.Ingredients.Dessert
{
    public class Cookie : Ingredient, IMenuItem
    {
        public Cookie() 
            :base(0)
        { 
        
        }
        public Cookie(int quantity)
            :base(quantity) 
        {

        }
    }
    public class ChocolateChipCookie : Ingredient, IMenuItem
    {
        public ChocolateChipCookie()
           : base(0)
        {

        }
        public ChocolateChipCookie(int quantity)
            : base(quantity)
        {

        }
    }
}