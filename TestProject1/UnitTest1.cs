using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigMamaUML3_Hannibal_;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MenuCatalogAddTest()
        {
            var catalog = new MenuCatalog();


            catalog.Add(new Beverage(1, "cola", "it's cola", 30, MenuType.SoftDrink, true, false, false));
            catalog.Add(new Pizza(2, "pizza", "tomato, chess, ham", 60, MenuType.Pizza, false, true, true));

            Assert.AreEqual(catalog.Count, 2);
        }
    }
}
