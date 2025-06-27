using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FoodForBots.Core
{
    public class RecipeBetterWay
    {
        public string Name { get; set; } = "AnyOldTextInHere2";
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public Dish Dish { get; set; } = new Dish();
    }
    public class Ingredient
    {
        public string Name { get; set; } = string.Empty;
        public IngredientType Type { get; set; }
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
        public RecipeBestWay(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }
        public string Name { get; set; } = "AnyOldTextInHere3";
        private readonly List<Ingredient> ingredients;
        public IEnumerable<Ingredient> Ingredients => ingredients;
        public Dish Dish { get; set; } = new Dish();
    }
}
