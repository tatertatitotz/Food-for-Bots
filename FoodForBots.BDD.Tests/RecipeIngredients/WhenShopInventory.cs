using FoodForBots.Contracts.Equipment;
using FoodForBots.Food.Core.Equipment.HeatAppliers;
using FoodForBots.Food.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FoodForBots.BDD.Tests.RecipeIngredients
{
    public class WhenShopInventory
    {
        [Fact]

        public void GetsEquipment_ItIsAlwaysAvailable()
        {
            var shopInventory = new ShopInventory();
            var oven = shopInventory.GetEquipment(typeof(Oven));
            Assert.NotNull(oven);

           
        }
        [Fact]

        public void GetsInvalidEquipment_ItReturnsNoEquipment()
        {
            var shopInventory = new ShopInventory();
            var cookie = shopInventory.GetEquipment(typeof(Cookie));
            Assert.NotNull(cookie);
            Assert.Equal(typeof(NoEquipment), cookie.GetType());


        }
    }
}
