// See https://aka.ms/new-console-template for more information
using FoodForBots.CLI.City;
using FoodForBots.Contracts.City;
using FoodForBots.Core.City;

Console.WriteLine("Hello, World!");
var cities = new List<ICity>();
var startingCity = new Beachland();
var controller = new CityNavigationController(cities, startingCity);
controller.DisplayCurrentLocation();
controller.AskToMove();