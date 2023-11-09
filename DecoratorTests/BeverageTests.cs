using DecoratorAssignment; // Assuming the namespace of the original code
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorTests
{
    [TestClass]
    public class BeverageTests
    {
        // Instructions:
        // To enable the tests, just remove the /* part above each test
        // You should use these tests to see that your solution works
        // and utilizes the decorator pattern correctly
        // NOTE! Don't modify the test themselves

        [TestMethod]
        public void EspressoTest()
        {
            Beverage beverage = new Espresso();
            Assert.AreEqual("Espresso", beverage.getDescription());
            Assert.AreEqual(1.99, beverage.cost());
        }
        
        [TestMethod]
        public void HouseBlendTest()
        {
            Beverage beverage = new HouseBlend();
            Assert.AreEqual("House Blend Coffee", beverage.getDescription());
            Assert.AreEqual(0.89, beverage.cost());
        }
        
        [TestMethod]
        public void DarkRoastWithCondimentsTest()
        {
            Beverage beverage = new DarkRoast();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Assert.AreEqual("Dark Roast Coffee, Mocha, Mocha, Whip", beverage.getDescription());
            Assert.AreEqual(1.49, beverage.cost());
        }
        
        [TestMethod]
        public void HouseBlendWithCondimentsTest()
        {
            Beverage beverage = new HouseBlend();
            beverage = new Soy(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Assert.AreEqual("House Blend Coffee, Soy, Mocha, Whip", beverage.getDescription());
            Assert.AreEqual(1.34, beverage.cost());
        }
        
        [TestMethod]
        public void DecafWithCondimentsTest()
        {
            Beverage beverage = new Decaf();
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Assert.AreEqual("Decaf Coffee, Mocha, Whip", beverage.getDescription());
            Assert.AreEqual(1.35, beverage.cost());
        }
    }
}
