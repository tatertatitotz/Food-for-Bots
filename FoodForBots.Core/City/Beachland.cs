using FoodForBots.Contracts.City;
using System.Collections.Generic;

namespace FoodForBots.Core.City
{
    public class Beachland : ICity
    {
        public Beachland()
        {
            Locations = new List<Location>() { Home, Restaurant, Store };
        }

        public Location Home { get; } = new Home();

        public List<Location> Locations { get; }

        public Location Restaurant { get; } = new OurRestaurant();

        public Location Store { get; } = new Store();
    }
}