namespace FoodForBots.Contracts.Ingredients
{
	public abstract class Ingredient : IIngredient
	{
		public string DisplayName { get; protected set; } = string.Empty;
	}
}