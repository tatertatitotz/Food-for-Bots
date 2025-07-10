using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Food.Core.Equipment
{
    public interface IEquipment
    {
        IEquipmentSetting Setting { get; set; }
    }
    public interface IEquipmentSetting
    {
        
    }
}
