using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FoodForBots.Core
{
    public class RecipeBetterWay
    {
        public string Name { get; set; } = "AnyOldTextInHere2";
        public List<RecipeIngredient> Ingredients { get; set; } = new List<RecipeIngredient>();
        public Dish Dish { get; set; } = new Dish();
    }
    public class RecipeIngredient
    {
        public Ingredient Ingredient { get; set; }
        public int Quantity { get; set; }
    }
    public class IngredientInventory
    {
        public Dictionary<Ingredient, int> Ingredients { get; set; } = new Dictionary<Ingredient, int>();
        public bool HasIngredient(Ingredient ingredient)
        {
            return Ingredients.ContainsKey(ingredient);
        }
        public bool HasEnoughIngredients(Ingredient ingredient, int quantity)
        {
            if (Ingredients.TryGetValue(ingredient, out var value)&& value >= quantity)
            {
                return true;
            }
            return false;
        }
    }
    public class Ingredient
    {
        public string Name { get; set; } = string.Empty;
    }
    public class FruitIngredient : Ingredient
    {
        public string Name { get; set; } = string.Empty;
        public FruitEnum Type { get; set; }
    }
    public class Fruit
    {
        public virtual void Cut()
        {

        }
    }
    public enum FruitEnum
    {
        Apple = 2000,
        Banana,
        Watermelon,
        Orange,

    }
    public interface IFruit
    {
        void Cut();
    }
    public abstract class BaseFruit
    {
        public abstract void Cut();

    }
    public abstract class IngredientType
    {
        public IngredientType(string name)
        {
            Name = name;
        }
        public string Name { get; } = string.Empty;
    }
    public class AppleType : IngredientType
    {
        public AppleType() : base("Apple")
        {

        }
    }

    public class Apple : Ingredient, IFruit
    {
        public Apple()
        {
            Name = "Apple";
        }

        public void Cut()
        {
            throw new NotImplementedException();
        }
    }
    public class Orange : Ingredient
    {
        public Orange()
        {
            Name = "Orange";
        }
    }
    public class Watermelon : BaseFruit
    {
        public Watermelon()
        {

        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
    }
    public class Banana : Fruit
    {
        public override void Cut()
        {

            base.Cut();
        }
        public Banana()
        {

        }
    }
    public class Grape : Ingredient
    {
        public Grape()
        {
            Name = "Grape";
        }
    }

    public class Dish
    {
        public string Name { get; set; } = string.Empty;

    }
    public class RecipeBestWay
    {
        public RecipeBestWay(List<RecipeIngredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        public string Name { get; set; } = "AnyOldTextInHere3";
        private readonly List<RecipeIngredient> ingredients;
        public IEnumerable<RecipeIngredient> Ingredients => ingredients;
        public Dish Dish { get; set; } = new Dish();
    }
}
