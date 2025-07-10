using FoodForBots.Contracts.Ingredients;
using FoodForBots.Food.Core.Equipment;
using System;
using System.Collections.Generic;

namespace FoodForBots.Contracts.Recipes
{
    public abstract class Recipe
    {
        //Take the cookie dough put it in balls place on baking tray then insert into "oven" at a specific temperature at a specfic time.
        protected readonly List<IEquipment> equipment = new List<IEquipment>();
        protected readonly List<IRecipeIngredient> ingredients = new List<IRecipeIngredient>();
        protected readonly List<IRecipeIngredient> output = new List<IRecipeIngredient>();
        public string DisplayName { get; protected set; } = string.Empty;
        public IEnumerable<IRecipeIngredient> Ingredients => ingredients;
        public IEnumerable<IRecipeIngredient> Output => output;

        protected void AddRequirement<TIngredient>(int quantity)
            where TIngredient : IIngredient
        {
            ingredients.Add(new RecipeIngredient<TIngredient>(quantity));
        }
        protected void AddOutput<TIngredient>(int quantity)
            where TIngredient : IIngredient
        {
            output.Add(new RecipeIngredient<TIngredient>(quantity));
        }
        protected void AddRequirement<TEquipment, TSetting>(int quantity, TSetting setting)
            where TEquipment : IEquipment, new()
            where TSetting : IEquipmentSetting
        {
            equipment.Add(new TEquipment() {Setting = setting});
        }
        
    }
}