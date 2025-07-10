using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Equipment.HeatAppliers
{
    public class Oven : IEquipment
    {
        public IEquipmentSetting Setting { get; set; } = new OvenSetting();
    }
    public class OvenSetting : IEquipmentSetting
    {
        public float Fahrenheit { get; set; }
        public float HeatingSeconds { get; set; }
    }
}
