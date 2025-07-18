using FoodForBots.Contracts.Equipment;
using FoodForBots.Contracts.Ingredients;
using FoodForBots.Food.Core.Equipment;
using System;

namespace FoodForBots.Food.Core.Inventories
{
    public class ShopInventory : IInventory
    {
        public TEquipment GetEquipment<TEquipment>() where TEquipment : IEquipment
        {
            throw new NotImplementedException();
        }
        [Obsolete("Use TryGetEquipment")]
        public IEquipment GetEquipment(Type type)
        {
            if (typeof(IEquipment).IsAssignableFrom(type))
                return (IEquipment)Activator.CreateInstance(type);
            return new NoEquipment();
        }

        public TIngredient GetIngredient<TIngredient>() where TIngredient : IIngredient
        {
            throw new NotImplementedException();
        }

        public IIngredient GetIngredient(Type type)
        {
            throw new NotImplementedException();
        }

        public bool TryGetEquipment(Type type, out IEquipment equipment)
        {
            equipment = new NoEquipment();
            var isEquipment = typeof(IEquipment).IsAssignableFrom(type);
            if (isEquipment)
                equipment = (IEquipment)Activator.CreateInstance(type);
            return isEquipment;
        }

        public bool TryGetIngredient(Type type, out IIngredient ingredient)
        {
            ingredient = new NoIngredient();
            var isIngredient = typeof(IIngredient).IsAssignableFrom(type);
            if (isIngredient)
                ingredient = (IIngredient)Activator.CreateInstance(type);
            return isIngredient;
        }
    }
}