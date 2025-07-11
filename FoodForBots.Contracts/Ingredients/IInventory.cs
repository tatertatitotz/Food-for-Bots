using FoodForBots.Food.Core.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Contracts.Ingredients
{
    public interface IInventory
    {
        TEquipment GetEquipment<TEquipment>()where TEquipment: IEquipment;
        TIngredient GetIngredient<TIngredient>() where TIngredient : IIngredient;
        IEquipment GetEquipment(Type type);
        IIngredient GetIngredient(Type type);
        bool TryGetEquipment(Type type, out IEquipment equipment);
        bool TryGetIngredient(Type type, out IIngredient ingredient);
    }

}
