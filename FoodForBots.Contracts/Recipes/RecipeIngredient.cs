using FoodForBots.Contracts.Ingredients;
using System;

namespace FoodForBots.Contracts.Recipes
{
    public interface IRecipeIngredient
    {
        int Quantity { get; }
        Type IngredientType { get; }

        bool IsIngredient<TIngredient>(TIngredient ingredient)
            where TIngredient : IIngredient;
    }

    public class RecipeIngredient<T> : IRecipeIngredient
    {
        protected readonly Type ingredientType;

        public RecipeIngredient(int quantity)
        {
            Quantity = quantity;
            ingredientType = typeof(T);
        }

        public int Quantity { get; }
        public Type IngredientType => ingredientType;

            public bool IsIngredient<TIngredient>(TIngredient ingredient) where TIngredient : IIngredient
        {
            var type = ingredient.GetType();
            return ingredientType.IsAssignableFrom(type);
        }
    }
}