using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachineTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void DisplayProducts() //Testimi i metodes per shfaqjene produkteve
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            var actualResult = vendingMachine.DisplayProducts(); // Thirrim metoden e cila i shfaq produktet ne stock
            var expected = "Product List: \nWater - 1 Euro\nCoffee - 2 Euro\nCoca-Cola - 3 Euro"; // Rezultati i pritur

            Assert.AreEqual(expected, actualResult); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem actual eshte vlera aktuale qe e kthen metoda
        }

        [TestMethod]
        public void EnteringMoneyTestOne() //Testimi i metodes EnteringMoney per vleren 0.05
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0.05; // Te insertuar jane 0.05 Euro
            var actual = vendingMachine.EnteringMoney(0.05); // Me ane te metodes EnteringMoney insertohen 0.05 Euro
            var expected = 0.10;

            Assert.IsFalse(actual); 
            Assert.AreEqual(expected, vendingMachine.TotalMoney); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem eshte 0.10 ndersa vendingMachine.TotalMoney eshte vlera aktuale 
        }

        [TestMethod]
        public void EnteringMoneyTestTwo() //Testimi i metodes EnteringMoney per vleren 0.10
        {
            VendingMachine_ vendingMachine = new VendingMachine_();  // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // Te insertuaa jane 0 Euro (nuk ka para te insertuara)
            var actual = vendingMachine.EnteringMoney(0.10); // Me ane te metodes EnteringMoney insertohen 0.10 Euro
            var expected = 0.10;

            Assert.IsFalse(actual);
            Assert.AreEqual(expected, vendingMachine.TotalMoney); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem eshte 0.10 ndersa vendingMachine.TotalMoney eshte vlera aktuale 
        }

        [TestMethod]
        public void EnteringMoneyTestThree() //Testimi i metodes EnteringMoney per vleren 0.20
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // Te insertuaa jane 0 Euro (nuk ka para te insertuara)
            var actual = vendingMachine.EnteringMoney(0.20); // Me ane te metodes EnteringMoney insertohen 0.10 Euro
            var expected = 0.20;

            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
            Assert.AreEqual(expected, vendingMachine.TotalMoney); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem eshte 0.10 ndersa vendingMachine.TotalMoney eshte vlera aktuale 
        }

        [TestMethod]
        public void EnteringMoneyTestFour() //Testimi i metodes EnteringMoney per vleren 0.50
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 1.00; // Te insertuaa jane 1.00 Euro 
            var actual = vendingMachine.EnteringMoney(0.50); // Me ane te metodes EnteringMoney insertohen 0.50 Euro
            var expected = 1.50;

            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
            Assert.AreEqual(expected, vendingMachine.TotalMoney); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem eshte 1.50 ndersa vendingMachine.TotalMoney eshte vlera aktuale 
        }

        [TestMethod]
        public void EnteringMoneyTestFive() //Testimi i metodes EnteringMoney per vleren 1.00
        {
            VendingMachine_ vendingMachine = new VendingMachine_();  // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // Nuk ka para te insertuara
            var actual = vendingMachine.EnteringMoney(1.00); // Me ane te metodes EnteringMoney insertohen 1.00 Euro
            var expected = 1.00;

            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
            Assert.AreEqual(expected, vendingMachine.TotalMoney); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem eshte 1.00 ndersa vendingMachine.TotalMoney eshte vlera aktuale 
        }

        [TestMethod]
        public void EnteringMoneyTestSix() //Testimi i metodes EnteringMoney per vleren 2.00
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 1.50; // 1.50 euro te insertuara
            var actual = vendingMachine.EnteringMoney(2.00); // Me ane te metodes EnteringMoney insertohen 1.00 Euro
            var expected = 3.50;

            Assert.AreEqual(expected, vendingMachine.TotalMoney); // Krahasohet rezultati nese eshte i barabart, vlera e pritshem eshte 3.50 ndersa vendingMachine.TotalMoney eshte vlera aktuale 
            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
        }

        [TestMethod]
        public void EnteringMoneyTestSeven() //Testimi i metodes EnteringMoney kur shtypim vleren -1 kur nuk kemi te insertua para, TotalMoney = 0 (Equal)
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // Nuk ka para te insertuara
            var actual = vendingMachine.EnteringMoney(-1); // Metoda EnteringMoney pranon vleren -1

            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
        }
        
        [TestMethod]
        public void EnteringMoneyTestEight() //Testimi i metodes EnteringMoney per vleren 10
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // Nuk ka para te insertuara
            var actual = vendingMachine.EnteringMoney(10); // Metoda EnteringMoney pranon vleren 10

            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
        }

        [TestMethod]
        public void EnteringMoneyTestNine() //Testimi i metodes EnteringMoney per vleren -10
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // Nuk ka para te insertuara
            var actual = vendingMachine.EnteringMoney(-10); // Metoda EnteringMoney pranon vleren -10
            
            Assert.IsFalse(actual); // Testohe nese enterMoney kthen False
        }

        [TestMethod] 
        public void EnteringMoneyTestTen() //Testimi i metodes EnteringMoney kur TotalMoney eshte vlere me e madhe se qmimi i produkteve
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 3; // Vlera momentale e parave eshte 3 Euro
            var actual = vendingMachine.EnteringMoney(2.00); // Me ane te metodes EnteringMoney insertohen 2 Euro

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EnteringMoneyTestEleven() //Testimi i metodes EnteringMoney per vleren -1 kur kemi te insertua para
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0;
            var actual = vendingMachine.EnteringMoney(0); // Metoda EnteringMoney pranon vleren -1

            Assert.IsFalse(actual); // Testohet nese entryMoney kthen rezultatin false
        }


        [TestMethod]
        public void EnteringMoneyTestTweleve() //Testimi i metodes EnteringMoney per vleren -1 kur kemi te insertua para
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 1;
            var actual = vendingMachine.EnteringMoney(-1); // Metoda EnteringMoney pranon vleren -1

            Assert.IsTrue(actual); // Testohet nese entryMoney kthen rezultatin false
        }

        [TestMethod]
        public void CheckMoneyTestOne() //Testimi i metodes CheckMoney kur TotalMoney = 1Euro, metoda kthen false
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 1; // TotalMoney ka vleren momentale 1.00 Euro
            var actual = vendingMachine.CheckMoney(); // Thirret metoda CheckMoney()

            Assert.IsFalse(actual); // Testohet nese entryMoney kthen vlere false
        }

        [TestMethod]
        public void CheckMoneyTestTwo() //Testimi i metodes CheckMoney kur TotalMoney eshte 1.50Euro, metoda kthen false
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 1.50; // TotalMoney ka vleren momentale 1.50 Euro
            var actual = vendingMachine.CheckMoney(); // Thirret metoda CheckMoney()

            Assert.IsFalse(actual); // Testohet nese entryMoney kthen vlere false
        }

        [TestMethod]
        public void CheckMoneyTestThree() //Testimi i metodes CheckMoney kur TotalMoney eshte 3.00 Euro, metoda kthen false
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 3.00; // TotalMoney ka vleren momentale 3.00 Euro
            var actual = vendingMachine.CheckMoney(); // Thirret metoda CheckMoney()

            Assert.IsFalse(actual); // Testohet nese entryMoney kthen vlere false
        }

        [TestMethod]
        public void CheckMoneyTestFour() //Testimi i metodes CheckMoney kur TotalMoney eshte 0Euro, metoda kthen false
        {
            VendingMachine_ vendingMachine = new VendingMachine_(); // Krijimi i nje instance te klases VendingMachine
            vendingMachine.TotalMoney = 0; // TotalMoney ka vleren momentale 3.00 Euro
            var actual = vendingMachine.CheckMoney(); // Thirret metoda CheckMoney()

            Assert.IsFalse(actual); // Testohet nese entryMoney kthen vlere false
        }

        [TestMethod]
        public void CheckMoneyTestFive() //Testimi i metodes CheckMoney kur refundAndExit eshte true
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.refundAndExit = true;
            var actual = vendingMachine.CheckMoney();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckProductAvailabilityTestOne() //Testimi i metodes CheckProductAvailability kur TotalMoney = 1.00 (paraqitet lista e produkteve qe mund te blehen)
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 1.00;
            var actual = vendingMachine.CheckProductAvailability();
            var expected = "List of available product(s):\n[A] Water - 1 Euro\n[X] Enter more Money/Refund\n\nPlease note your selection:";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckProductAvaiabilityTestTwo() //Testimi i metodes CheckProductAvailability kur TotalMoney = 2.00 (paraqitet lista e produkteve qe mund te blehen)
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.10;
            var actual = vendingMachine.CheckProductAvailability();
            var expected = "List of available product(s):\n[A] Water - 1 Euro\n[B] Coffee - 2 Euro\n[X] Enter more Money/Refund\n\nPlease note your selection: ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckProductAvaiabilityTestThree() //Testimi i metodes CheckProductAvailability kur TotalMoney = 4.10 (paraqitet lista e produkteve qe mund te blehen)
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 4.10;
            var actual = vendingMachine.CheckProductAvailability();
            var expected = "List of available product(s):\n[A] Water - 1 Euro\n[B] Coffee - 2 Euro\n[C] Coca-Cola - 3 Euro\n[X] Enter more Money/Refund\n\nPlease note your selection: ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckProductAvaiabilityTestFour() //Testimi i metodes CheckProductAvailability kur TotalMoney = 0.10 (paraqitet lista e produkteve qe mund te blehen
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 0.10;
            var actual = vendingMachine.CheckProductAvailability();
            var expected = "[X] Enter more Money/Refund: ";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestOne() //Testimi i metodes DispenseProduct kur TotalMoney = 1.20, selektojme produktin A = Water per blerje
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 1.20;
            var actual = vendingMachine.DispenseProduct('A');
            var expected = "1. You have entered 1.2 Euro\n2. You have bought Water 1 Euro\n3. Your change is 0.2 Euro";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestTwo() //Testimi i metodes DispenseProduct kur selektojme A = Water per blerje por nuk kemi para te mjaftueshme, TotalMoney = 0.10
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 0.20;
            var actual = vendingMachine.DispenseProduct('A');
            var expected = "Access to this product is restricted \n\n[X] To continue";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestThree() //Testimi i metodes DispenseProduct kur TotalMoney = 1.20, selektojme produktin B = Coffee per blerje
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.20;
            var actual = vendingMachine.DispenseProduct('B');
            var expected = "1. You have entered 2.2 Euro\n2. You have bought Coffee 2 Euro\n3. Your change is 0.2 Euro";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestFour() //Testimi i metodes DispenseProduct kur selektojme B = Coffee per blerje por nuk kemi para te mjaftueshme, TotalMoney = 1.80
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 1.80;
            var actual = vendingMachine.DispenseProduct('B');
            var expected = "Access to this product is restricted \n\n[X] To continue";

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DispenseProductTestFive() //Testimi i metodes DispenseProduct kur TotalMoney = 1.20, selektojme produktin C = Coca-Cola per blerje
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 3.10;
            var actual = vendingMachine.DispenseProduct('C');
            var expected = "1. You have entered 3.1 Euro\n2. You have bought Coca-Cola 3 Euro\n3. Your change is 0.1 Euro";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestSix() //Testimi i metodes DispenseProduct kur selektojme C = Coca-Cola per blerje por nuk kemi para te mjaftueshme, TotalMoney = 2.80
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.80;
            var actual = vendingMachine.DispenseProduct('C');
            var expected = "Access to this product is restricted \n\n[X] To continue";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestSeven() //Testimi i metodes DispenseProduct kur metoda pranon parameter gabim
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.80;
            var actual = vendingMachine.DispenseProduct('S');
            var expected = "Invalid Selection. Please re-enter your selection";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DispenseProductTestEight() //Testimi i metodes DispenseProduct kur selektojme X per te anuluar procesin apo vazhduar me insertimin e parave, TotalMoney = 2.80
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.80;
            var actual = vendingMachine.DispenseProduct('X');
            var expected = "Return/Refund";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnChangeTestOne() //Testimi i metodes ReturnChange ne rastin kur TotalMoney eshte 2.00 Euro dhe qmimi i produktit eshte 1 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.00;
            var actual = vendingMachine.ReturnChange(1.00);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnChangeTestTwo() //Testimi i metodes ReturnChange ne rastin kur TotalMoney eshte 2.00 Euro dhe qmimi i produktit eshte 2 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 2.00;
            var actual = vendingMachine.ReturnChange(2);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnChangeTestThree() //Testimi i metodes ReturnChange ne rastin kur TotalMoney eshte 3.00 Euro dhe qmimi i produktit eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 3.00;
            var actual = vendingMachine.ReturnChange(3.00);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnChangeTestFour() //Testimi i metodes ReturnChange ne rastin kur TotalMoney eshte 3.00 Euro dhe qmimi i produktit eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 3.00;
            var actual = vendingMachine.ReturnChange(0);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnChangeTestFive() //Testimi i metodes ReturnChange ne rastin kur TotalMoney eshte 3.00 Euro dhe qmimi i produktit eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 3.00;
            var actual = vendingMachine.ReturnChange(-10);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnChangeTestSix() //Testimi i metodes ReturnChange ne rastin kur TotalMoney eshte 3.00 Euro dhe qmimi i produktit eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 3.00;
            var actual = vendingMachine.ReturnChange(10);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void PayTestOne() //Testimi i metodes Pay ne rastin kur TotalMoney eshte 4 Euro dhe per pagese eshte 1 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 4.00;
            var actual = vendingMachine.Pay(1.00);
            var expected = 1.00;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayTestTwo() //Testimi i metodes Pay ne rastin kur TotalMoney eshte 3 Euro dhe per pagese eshte 2 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 3.00;
            var actual = vendingMachine.Pay(2.00);
            var expected = 2.00;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayTestThree() //Testimi i metodes Pay ne rastin kur TotalMoney eshte 4 Euro dhe per pagese eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 4.00;
            var actual = vendingMachine.Pay(3.00);
            var expected = 3.00;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayTestFour() //Testimi i metodes Pay ne rastin kur TotalMoney eshte 4 Euro dhe per pagese eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 4.00;
            var actual = vendingMachine.Pay(0);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayTestFive() //Testimi i metodes Pay ne rastin kur TotalMoney eshte 4 Euro dhe per pagese eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 4.00;
            var actual = vendingMachine.Pay(-1);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PayTestSix() //Testimi i metodes Pay ne rastin kur TotalMoney eshte 4 Euro dhe per pagese eshte 3 Euro
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 4.00;
            var actual = vendingMachine.Pay(10);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RefundMoneyTestOne() //Testimi i metodes RefndMoney ne rastin kur kemi insertu 3Euro dhe anulojme procesin
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.RefundMoney(3);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RefundMoneyTestTwo() //Testimi i metodes RefndMoney ne rastin kur kemi insertu 2Euro dhe anulojme procesin
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.RefundMoney(2);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RefundMoneyTestThree() //Testimi i metodes RefndMoney ne rastin kur kemi insertu 3.5Euro dhe anulojme procesin
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.RefundMoney(3.5);
            var expected = 3.5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RefundMoneyTestFour() //Testimi i metodes RefndMoney ne rastin kur metoda pranon si paameter 0
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.RefundMoney(0);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RefundMoneyTestFive() //Testimi i metodes RefndMoney ne rastin kur metoda pranon si paameter -1
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.RefundMoney(-1);
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestOne() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 0.50, dhe vazhdojme me insertu 0.05 EURO
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 0.05;
            var actual = vendingMachine.ContinueOrRefund(0.05);
            var expected = 0.10;

            Assert.AreEqual(expected, vendingMachine.TotalMoney);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestTwo() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 0.10, dhe vazhdojme me insertu 0.10 EURO
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 0.10;
            var actual = vendingMachine.ContinueOrRefund(0.10);
            var expected = 0.20;

            Assert.AreEqual(expected, vendingMachine.TotalMoney);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestThree() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 1.00, dhe insertojme 0.20 EURO
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 1.00;
            var actual = vendingMachine.ContinueOrRefund(0.20);
            var expected = 1.20;

            Assert.AreEqual(expected, vendingMachine.TotalMoney);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestFour() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 1.00, dhe insertojme 0.50 EURO
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 1.00;
            var actual = vendingMachine.ContinueOrRefund(0.50);
            var expected = 1.50;

            Assert.AreEqual(expected, vendingMachine.TotalMoney);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestFive() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 0, dhe insertojme 1.00 EURO
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 0;
            var actual = vendingMachine.ContinueOrRefund(1.00);
            var expected = 1.00;

            Assert.AreEqual(expected, vendingMachine.TotalMoney);
            Assert.IsFalse(actual);
        }
        
        [TestMethod]
        public void ContinueOrRefundTestSix() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 1.50, dhe insertojme 2.00 EURO
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 1.50;
            var actual = vendingMachine.ContinueOrRefund(2.00);
            var expected = 3.50;

            Assert.AreEqual(expected, vendingMachine.TotalMoney);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestSeven() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 0.50 dhe metoda pranon si parametet -1
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            vendingMachine.TotalMoney = 0.50;
            var actual = vendingMachine.ContinueOrRefund(-1);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestEight() //Testimi i metodes ContinueOrRefund ne rastin kur TotalMoney = 1.50, dhe metoda pranon si parametet -2
        {
            VendingMachine_ vendingMachine = new VendingMachine_();

            double money = vendingMachine.TotalMoney = 1.50;
            var actual = vendingMachine.ContinueOrRefund(-2);
            var refund = vendingMachine.RefundMoney(money);
            var expected = 1.50;

            Assert.AreEqual(expected, refund);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestNine() //Testimi i metodes ContinueOrRefund ne rastin kur metoda pranon si parametet 0
        {
            VendingMachine_ vendingMachine = new VendingMachine_();

            var actual = vendingMachine.ContinueOrRefund(0);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestTen() //Testimi i metodes ContinueOrRefund ne rastin kur metoda pranon si parametet 10
        {
            VendingMachine_ vendingMachine = new VendingMachine_();

            var actual = vendingMachine.ContinueOrRefund(10);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void ContinueOrRefundTestEleven() //Testimi i metodes ContinueOrRefund ne rastin kur metoda pranon si parametet -12
        {
            VendingMachine_ vendingMachine = new VendingMachine_();

            var actual = vendingMachine.ContinueOrRefund(-12);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckRefundCoinTestOne() //Testimi i metodes CheckRefundMoney ne rastin kur TotalMoney = 2.10, dhe metoda pranon si parameter R
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var totalMoney = vendingMachine.TotalMoney = 2.10;
            vendingMachine.CheckRefundMoney('R');
            var actualMoney = vendingMachine.RefundMoney(totalMoney);
            var expected = 2.10;

            Assert.AreEqual(expected, actualMoney);
        }

        [TestMethod]
        public void CheckRefundCoinTestTwo() //Testimi i metodes CheckRefundMoney ne rastin kur TotalMoney = 3.10, dhe metoda pranon si parameter C
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var totalMoney = vendingMachine.TotalMoney = 3.10;
            var actual = vendingMachine.CheckRefundMoney('C');
            Assert.IsFalse(actual); 
        }

        [TestMethod]
        public void CheckRefundCoinTestThree() //Testimi i metodes CheckRefundMoney ne rastin kur metoda pranon si parameter R
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var totalMoney = vendingMachine.TotalMoney = 2.10;
            var actual = vendingMachine.CheckRefundMoney('R');
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckRefundCoinTestFour() //Testimi i metodes CheckRefundMoney ne rastin kur metoda pranon si parameter C
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var totalMoney = vendingMachine.TotalMoney = 3.10;
            var actual = vendingMachine.CheckRefundMoney('B');

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void InstockTestOne() //Testimi i metodes ContinueOrRefund ne rastin kur Instock = 9, per blerje selektojme Water
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.Instock("Water");
            var expected = 8;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InstockTestTwo() //Testimi i metodes ContinueOrRefund ne rastin kur Instock = 5, per blerje selektojme Coffee
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.Instock("Coffee");
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InstockTestThree() //Testimi i metodes ContinueOrRefund ne rastin kur Instock = 7, per blerje selektojme Coke
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.Instock("Coca-Cola");
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InstockTestFour() //Testimi i metodes ContinueOrRefund ne rastin kur Instock = 7, per blerje selektojme Coke
        {
            VendingMachine_ vendingMachine = new VendingMachine_();
            var actual = vendingMachine.Instock("Test");
            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
