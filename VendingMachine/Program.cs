using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine_();

            bool continueToBuy = true;

            while (continueToBuy)
            {
                Console.WriteLine(vendingMachine.DisplayProducts()); // thirret metoda per shfaqjen e produkteve
                Console.WriteLine("\nPlease enter any of coins: 0.05, 0.10, 0.20, 0.50, 1.00, 2.00");
                Console.WriteLine("\nPress any key to start entering money!");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("[-1] Finish entering coin");
                Console.WriteLine();
                Console.Write("Start entering coin: ");

                while (!vendingMachine.EnteringMoney(Convert.ToDouble(Console.ReadLine()))) // thirret metoda per insertimin e parave 
                {
                    Console.Write("Enter more coin: ");
                }

                Console.WriteLine();
                Console.WriteLine("[R] Request Refund");
                Console.WriteLine("[C] Check Total");

                while (!vendingMachine.selectionCheck)
                {
                     vendingMachine.CheckRefundMoney(Convert.ToChar(Console.ReadLine().ToUpper())); //thirret metoda per konrollimin e insertimit te parave apo anulimin e procesit
                }

                vendingMachine.selectionCheck = false;

                if (vendingMachine.refundAndExit == false)
                {
                    while (!vendingMachine.CheckMoney()) // thirret metoda per kontrollimin e parave ku varesisht parave te insertuara shfaqen produktet e disponueshme
                    {
                        vendingMachine.ContinueOrRefund(Convert.ToDouble(Console.ReadLine())); // thirret metoda per te vazhduar apo anuluar procesin
                        
                        while (!vendingMachine.selectionDispence)
                        {
                            vendingMachine.DispenseProduct(Convert.ToChar(Console.ReadLine().ToUpper())); // thirret metoda per selektimin e produktit
                        }

                        vendingMachine.selectionDispence = false;
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}