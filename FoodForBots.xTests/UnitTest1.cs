using FoodForBots.Core;

namespace FoodForBots.xTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var worst = new RecipeTheWrongWay();
            var better = new RecipeBetterWay();
            var best = new RecipeBestWay();
            worst.Name = "AnyOldTextInHere2";
            Assert.Equal("AnyOldTextInHere2", worst.Name);
        }
    }
}