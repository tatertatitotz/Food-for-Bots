namespace FoodForBots.Contracts.Ingredients
{
    public abstract class Ingredient : IIngredient
    {
        public Ingredient(int quantity)
        {
            Quantity = quantity;
        }

        public string DisplayName { get; protected set; } = string.Empty;

        public int Quantity { get; protected set; }
    }
}