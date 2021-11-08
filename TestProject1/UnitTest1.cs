using System;
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
            //arrange
            var catalog = new MenuCatalog();

            //act
            catalog.Add(new Beverage(1, "cola", "it's cola", 30, MenuType.SoftDrink, true, false, false));
            catalog.Add(new Pizza(2, "pizza", "tomato, chess, ham", 60, MenuType.Pizza, false, true, true));

            //assert
            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void MenuCatalogSearchTest()
        {
            //arrange
            MenuCatalog catalog = new MenuCatalog();
            MenuItem pizza = new Pizza(5, "pizza5", "tomato chess ham pineapple", 65, MenuType.Pizza, false, true,
                false);

            //act
            catalog.Add(new Beverage(1, "cola", "it's cola", 30, MenuType.SoftDrink, true, false, false));
            catalog.Add(new Pizza(2, "pizza", "tomato, chess, ham", 60, MenuType.Pizza, false, true, true));
            catalog.Add(pizza);

            //assert
            Assert.AreSame(pizza, catalog.Search(5));
        }

        [TestMethod]
        public void MenuCatalogRemoveTest()
        {
            //arrange
            var catalog = new MenuCatalog();

            //act
            catalog.Add(new Beverage(1, "cola", "it's cola", 30, MenuType.SoftDrink, true, false, false));
            catalog.Add(new Pizza(2, "pizza", "tomato, chess, ham", 60, MenuType.Pizza, false, true, true));
            catalog.Delete(1);
            catalog.Delete(2);

            //assert
            Assert.AreEqual(0, catalog.Count);
        }

        [TestMethod]
        public void MenuCatalogMostexpensivTest()
        {
            //arrange
            MenuCatalog catalog = new MenuCatalog();

            //act
            catalog.Add(new Pizza(2, "pizza", "tomato, chess, ham", 70, MenuType.Pizza, false, true, true));
            catalog.Add(new Pizza(6, "pizza", "tomato, chess, ham", 80, MenuType.Pizza, false, true, true));
            catalog.Add(new Pizza(4, "pizza", "tomato, chess, ham", 60, MenuType.Pizza, false, true, true));
            catalog.Add(new Beverage(1, "cola", "it's cola", 30, MenuType.SoftDrink, true, false, false));
            catalog.Add(new Beverage(3, "cola", "it's cola", 25, MenuType.SoftDrink, true, false, false));
            catalog.Add(new Beverage(5, "cola", "it's cola", 41, MenuType.SoftDrink, true, false, false));

            //assert
            Assert.AreEqual(80, catalog.MostExpensiveMenuItem().Price);
        }

        [TestMethod]
        public void MenuItemNumberExistTest()
        {
            //arrange
            MenuCatalog catalog = new MenuCatalog();

            //act
            catalog.Add(new Beverage(1,"cola","it's fucking cola",30,MenuType.SoftDrink,true,false,false));

            Action AddWithSameNumber = () =>
                catalog.Add(new Pizza(1, "pizza", "IDK", 60, MenuType.Pizza, false, false, true));

            //assert
            Assert.ThrowsException<MenuItemNumberExist>(AddWithSameNumber);
        }
    }
}
