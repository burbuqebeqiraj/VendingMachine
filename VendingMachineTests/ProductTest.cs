using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachineTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod()]
        public void ProductInstantiation() // Testohet nese Water eshte instanc e produktit
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.IsInstanceOfType(water, typeof(Products));
        }

        [TestMethod()]
        public void WaterNameTestNotEqual() // Testohet kur emri i produktit Water nuk eshte i njejte
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual("Bottled Water", water.Name);
        }

        [TestMethod()]
        public void WaterNameTestEqual() // Testohet kur emri i produktit Water eshte i njejte
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreEqual("Water", water.Name);
        }

        [TestMethod()]
        public void WaterPriceTestEqual() // Testohet kur cmimi i produktit Water eshte i njejte
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreEqual(1.00, water.Price);
        }

        [TestMethod()]
        public void WaterPriceTestNotEqualPozitiveNo() // Testohet kur cmimi i produktit Water nuk eshte i njejte - vlera 10
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual(10.00, water.Price);
        }

        [TestMethod()]
        public void WaterPriceTestNotEqualZero() // Testohet kur cmimi i produktit Water nuk eshte i njejte - vlera 0
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual(0, water.Price);
        }

        [TestMethod()]
        public void WaterPriceTestNotEqualNegativNo() // Testohet kur cmimi i produktit Water nuk eshte i njejte - vlera -1
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual(-1, water.Price);
        }

        [TestMethod()]
        public void WaterInstockTestEqual() // Testohet kur sasia e produktit Water eshte e njejte
        {
            Products water = new Products("Water", 1.00, 9); ;
            Assert.AreEqual(9, water.Instock);
        }

        [TestMethod()]
        public void WaterInstockTestNotEqualPozitiveNo() // Testohet kur saisa e produktit Water nuk eshte e njejte - vlera 19
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual(19, water.Instock);
        }

        [TestMethod()]
        public void WaterInstockTestNotEqualZero() // Testohet kur sasia e produktit Water nuk eshte i njejte - vlera 0
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual(0, water.Instock);
        }

        [TestMethod()]
        public void WaterInstockTestNotEqualnegativeNo() // Testohet kur sasia e produktit Water nuk eshte i njejte - vlera -1
        {
            Products water = new Products("Water", 1.00, 9);
            Assert.AreNotEqual(-1, water.Instock);
        }

        [TestMethod()]
        public void CokeInstantiation() // Testohet nese produkti Coca-Cola eshte instanc e Products
        {
            Products coke = new Products("Coca-Cola", 3.00, 7); 
            Assert.IsInstanceOfType(coke, typeof(Products));
        }

        [TestMethod()]
        public void CokeNameTestNotEqual() // Testohet kur emri i produktit Cocla-Cola nuk eshte i njejte
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual("Bottled Coke", coke.Name);
        }

        [TestMethod()]
        public void CokeNameTestEqual() // Testohet kur emri i produktit Cocla-Cola eshte i njejte
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreEqual("Coca-Cola", coke.Name);
        }

        [TestMethod()]
        public void CokePriceTestEqual()  // Testohet kur cmimi i produktit Cocla-Cola eshte i njejte
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreEqual(3.00, coke.Price);
        }

        [TestMethod()]
        public void CokePriceTestNotEqual_10()  // Testohet kur cmimi i produktit Coca-Cola nuk eshte i njejte - vlera 10
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual(10.00, coke.Price);
        }

        [TestMethod()]
        public void CokePriceTestNotEqual_0() // Testohet kur cmimi i produktit Coca-Cola nuk eshte i njejte - vlera 
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual(0, coke.Price);
        }

        [TestMethod()]
        public void CokePriceTestNotEqual_1() // Testohet kur cmimi i produktit Coca-Cola nuk eshte i njejte - vlera -1
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual(-1.00, coke.Price);
        }

        [TestMethod()]
        public void CokeInstockTestEqual() // Testohet kur sasia e produktit Coca-Cola eshte i njejte
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreEqual(7, coke.Instock);
        }

        [TestMethod()]
        public void CokeInstockTestNotEqual_19() // Testohet kur sasia e produktit Coca-Cola nuk eshte i njejte - vlera 19
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual(19, coke.Instock);
        }

        [TestMethod()]
        public void CokeInstockTestEqual_0() // Testohet kur sasia e produktit Coca-Cola nuk eshte i njejte - vlera 0
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual(0, coke.Instock);
        }

        [TestMethod()]
        public void CokeInstockTestNotEqual_1() // Testohet kur sasia e produktit Coca-Cola nuk eshte i njejte - vlera -1
        {
            Products coke = new Products("Coca-Cola", 3.00, 7);
            Assert.AreNotEqual(-1, coke.Instock);
        }

        [TestMethod()]
        public void ProductInstantiationTest() // Metoda per te testuar nese produkti (objekti) eshte instance e Coffee
        {
            Products coffee = new Products("Coffee", 2.00, 5); //Krijimi i nje objekti te klases Coffee
            Assert.IsInstanceOfType(coffee, typeof(Products));  //Testimi se a eshte objekti coffee i tipi Coffee
        }

        [TestMethod()]
        public void CoffeeNameTestNotEqual() // Testohet kur emri i produktit Coffee nuk eshte i njejte
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual("Bottled Coke", coffee.Name);
        }

        [TestMethod()]
        public void CoffeeNameTestEqual() // Testohet kur emri i produktit Co nuk eshte i njejte
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreEqual("Coffee", coffee.Name);
        }

        [TestMethod()]
        public void CoffeePriceTestEqual() // Testohet kur cmimi i produktit Coffee eshte i njejte
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreEqual(2.00, coffee.Price);
        }

        [TestMethod()]
        public void CoffeePriceTestNotEqual_10() // Testohet kur cmimi i produktit Coffee nuk eshte i njejte - vlera 10
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual(10.00, coffee.Price);
        }

        [TestMethod()]
        public void CoffeePriceTestNotEqual_0() // Testohet kur cmimi i produktit Coffee nuk eshte i njejte - vlera 0
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual(0, coffee.Price);
        }

        [TestMethod()]
        public void CoffeePriceTestNotEqual_1() // Testohet kur cmimi i produktit Coffee nuk eshte i njejte - vlera -1
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual(-1.00, coffee.Price);
        }

        [TestMethod()]
        public void CoffeeInstockTestEqual() // Testohet kur sasia e produktit Coffee eshte i njejte
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreEqual(5, coffee.Instock);
        }

        [TestMethod()]
        public void CoffeeInstockTestNotEqual_19() // Testohet kur sasia e produktit Coffee nuk eshte i njejte - vlera 19
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual(19, coffee.Instock);
        }

        [TestMethod()]
        public void CoffeeInstockTestEqual_0() // Testohet kur sasia e produktit Coffee nuk eshte i njejte - vlera 0
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual(0, coffee.Instock);
        }

        [TestMethod()]
        public void CoffeeInstockTestNotEqual_1() // Testohet kur sasia e produktit Coffee nuk eshte i njejte - vlera -1
        {
            Products coffee = new Products("Coffee", 2.00, 5);
            Assert.AreNotEqual(-1, coffee.Instock);
        }
    }
}
