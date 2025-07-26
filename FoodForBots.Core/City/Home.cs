using FoodForBots.Contracts.City;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Core.City
{
    public class Home : Location
    {
        public override string DisplayName { get; protected set; } = "Home";
    }
}
