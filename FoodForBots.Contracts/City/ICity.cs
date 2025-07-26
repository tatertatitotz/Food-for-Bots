using System.Collections.Generic;

namespace FoodForBots.Contracts.City
{
    public interface ICity
    {
        Location Home { get; }
        List<Location> Locations { get; }
        Location Restaurant { get; }
        Location Store { get; }
    }
}