using FoodForBots.Contracts.City;
using FoodForBots.Core.City;
using Sharprompt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodForBots.CLI.City
{
    public class CityNavigationController

    {
        private readonly List<ICity> cities;
        private readonly ICity startingCity;
        public CityNavigationController(List<ICity> cities, ICity startingCity)
        {
            this.cities = cities;
            this.startingCity = startingCity;
            CurrentLocation = startingCity.Home;
            CurrentCity = startingCity;
        }
        public void Go(Location location)
        {
            CurrentLocation = location;
            DisplayCurrentLocation();
        }
        public void Go(ICity city)
        {
            CurrentCity = city;
            CurrentLocation = city.Home;
        }
        private ICity CurrentCity { get; set; }
        private Location CurrentLocation { get; set; }
        public void DisplayCurrentLocation()
        {
            Console.WriteLine($"Currently at {CurrentLocation.DisplayName}");
        }
        public void AskToMove()
        {
            var newLocation = Prompt.Select("Move to Location", CurrentCity.Locations, textSelector: (city) => city.DisplayName);
            Go(newLocation);
        }
    }
}
