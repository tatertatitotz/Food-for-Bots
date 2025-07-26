using System;
using System.Collections.Generic;
using System.Text;

namespace FoodForBots.Contracts.City
{
    public abstract class Location
    {
        public abstract string DisplayName { get; protected set; } 
    }
}
