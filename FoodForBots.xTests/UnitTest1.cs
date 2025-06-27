using FoodForBots.Core;

namespace FoodForBots.xTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var better = new RecipeBetterWay();
            var best = new RecipeBestWay(new List<Ingredient>());

            better.Name = "AnyOldTextInHere1";
            best.Name = "AnyOldTextInHere2";

            Assert.Equal("AnyOldTextInHere1", better.Name);
            Assert.Equal("AnyOldTextInHere2", best.Name);
        }
        [Fact]
        public void Test2()
        {
            var ingredient = new Ingredient();
            var ingredients = new List<Ingredient>() { ingredient };
            var better = new RecipeBetterWay();
            var best = new RecipeBestWay(ingredients);

            better.Ingredients = ingredients;

            Assert.Equal(ingredient, better.Ingredients.First());
            Assert.Equal(ingredient, best.Ingredients.First());
        }
        [Fact]
        public void Test3()
        {
            var dish = new Dish();
            var better = new RecipeBetterWay();
            var best = new RecipeBestWay(new List<Ingredient>());

            better.Dish = dish;
            best.Dish = dish;

            Assert.Equal(dish, better.Dish);
            Assert.Equal(dish, best.Dish);
        }
        [Fact]
        public void Test4()
        {
            var something = new Ingredient();
            var apple = new Apple();
            var watermelon = new Watermelon();
            var banana = new Banana();
            var grape = new Grape();
            var orange = new Orange();
            var fruitSomething = new FruitIngredient();

            something.Type = new AppleType();
            fruitSomething.Type = FruitEnum.Apple;
            fruitSomething.Name = "Apple";
            switch (fruitSomething.Type)
            {
                case FruitEnum.Apple:
                    Assert.True(true);
                    break;
                case FruitEnum.Banana:
                    Assert.True(true);
                    break;
                case FruitEnum.Watermelon:
                    Assert.True(true);
                    break;
            
            }
           if(something.Type is AppleType type)
            {
                Assert.Equal("Apple", type.Name);
            }
            Assert.Equal("Apple", apple.Name);
        }
        [Fact]
        public void Test5()
        {
            var something = new Ingredient();
            var apple = new Apple();
            var watermelon = new Watermelon();
            var banana = new Banana();
            var grape = new Grape();
            var orange = new Orange();
            var fruitSomething = new FruitIngredient();

            something.Type = new AppleType();
            fruitSomething.Type = FruitEnum.Apple;
            switch (fruitSomething.Type)
            {
                case FruitEnum.Apple:
                    Assert.True(true);
                    break;
                case FruitEnum.Banana:
                    Assert.True(true);
                    break;
                case FruitEnum.Watermelon:
                    Assert.True(true);
                    break;

            }
        }
        [Fact]
        public void Test6()
        {
            var something = new Ingredient();
            var apple = new Apple();
            var watermelon = new Watermelon();
            var banana = new Banana();
            var grape = new Grape();
            var orange = new Orange();
            var fruitSomething = new FruitIngredient();

            something.Type = new AppleType();
            fruitSomething.Type = FruitEnum.Apple;
            switch (fruitSomething.Type)
            {
                case FruitEnum.Apple:
                    Assert.True(true);
                    break;
                case FruitEnum.Banana:
                    Assert.True(true);
                    break;
                case FruitEnum.Watermelon:
                    Assert.True(true);
                    break;

            }
        }
        [Fact]
        public void Test7()
        {
            var something = new Ingredient();
            var apple = new Apple();
            var watermelon = new Watermelon();
            var banana = new Banana();
            var grape = new Grape();
            var orange = new Orange();
            var fruitSomething = new FruitIngredient();

            something.Type = new AppleType();
            fruitSomething.Type = FruitEnum.Orange;
            switch (fruitSomething.Type)
            {
                case FruitEnum.Apple:
                    Assert.True(true);
                    break;
                case FruitEnum.Banana:
                    Assert.True(true);
                    break;
                case FruitEnum.Watermelon:
                    Assert.True(true);
                    break;
                default: Assert.Fail();
                    break;
            }
        }
    }
}