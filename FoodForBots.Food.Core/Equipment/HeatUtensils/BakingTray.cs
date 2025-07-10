using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Equipment.HeatUtensils
{
    public class BakingTray : IEquipment
    {
        public IEquipmentSetting Setting { get; set; } = new DefaultSetting();
    }
    public class DefaultSetting : IEquipmentSetting
    {

    }
}
