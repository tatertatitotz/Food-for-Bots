using FoodForBots.Food.Core.Equipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Contracts.Equipment
{
    public class NoEquipment : IEquipment
    {
        public IEquipmentSetting Setting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
