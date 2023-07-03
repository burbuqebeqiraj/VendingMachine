using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine_
    {
        //Deklarimi i produkteve sipas parametrave name, price dhe instock
        Products water = new Products("Water", 1.00, 9);
        Products coffee = new Products("Coffee", 2.00, 5);
        Products coke = new Products("Coca-Cola", 3.00, 7);

        //Deklarimi i variables TotalMoney ku ruhet parat e insertuara
        public double TotalMoney { get; set; }

        //Deklarimi i variables refundAndExit, e cila kur behet True klienti i kthehen parat e insertuara
        public bool refundAndExit = false;

        //Deklarimi i variables selectionCheck, e cila perdoret kur shfaqet lista e produkteve qe jane te disponueshme
        public bool selectionCheck = false;

        //Deklarimi i variables selectionCheck, e cila perdoret ne rastin e selektimit te produkteve
        public bool selectionDispence = false;

        // Konstruktori ne e cilin incializohet variabla TotalMoney
        public VendingMachine_()
        {
            TotalMoney = 0;
        }

        // Metoda DisplayProducts shfaq listen e produkteve qe jane te disponueshme dhe qmimin e tyre
        public string DisplayProducts() //Tested
        {
            return "Product List: \n" + water.name + " - " + water.price + " Euro\n" + coffee.name + " - " + coffee.price + " Euro\n" + coke.name + " - " + coke.price + " Euro";
        }

        // Metoda EnteringMoney e tipit double, pranon nje parameter double
        // Permes kesaj metode behet insertimi i parave
        public bool EnteringMoney(double money)
        {
            if (TotalMoney < coke.price) // nese totali eshte me i vogel se qmimi i produktit coke (si qmimi me i larte), vazhdohet tutje
            {
                if (money == 0.05) // nese insertojme 0.05 Euro
                {
                    TotalMoney += 0.05; // totali rritet per 0.05
                    return false;
                }
                else if (money == 0.10) // nese insertojme 0.10
                {
                    TotalMoney += 0.10; // totali rritet per 0.10
                    return false;
                }
                else if (money == 0.20) // nese insertojme 0.10
                {
                    TotalMoney += 0.20; // totali rritet per 0.20
                    return false;
                }
                else if (money == 0.50) // nese insertojme 0.50 Euro
                {
                    TotalMoney += 0.50; // totali rritet per 0.50
                    return false;
                }
                else if (money == 1.00) // nese insertojme 1.00 Euro
                {
                    TotalMoney += 1.00; // totali rritet per 1.00
                    return false;
                }
                else if (money == 2.00) // nese insertojme 2.00 Euro
                {
                    TotalMoney += 2.00; // totali rritet per 2.00
                    return false;
                }
                else if (money == -1) // nese shtypim vleren -1
                {
                    if (TotalMoney == 0) // dhe totali eshte zero
                    {
                        Console.WriteLine("Please start inserting coin(s)."); // Paraqitet mesazhi per insertim te parave
                        return false;
                    }
                    else
                    {
                        return true; // nese totali nuk eshte zero ktheh true, programi vazhdon ne hapin e ardhshem
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry. Coin ejected"); // nese vlera e insertuar e ndryshme nga -1 paraqitet ky mesazh
                    return false;
                }
            }
            else
            {
                // Nese arrihet qmimi me i larte i produkteve, vazhdohet ne hapin e ardhshem 
                Console.WriteLine("\nLatest Coin not inserted!");
                Console.WriteLine("Process inserting coin finished!");
                return true;
            }
        }

        //Metoda CheckMoney e tipit boolean, ne baze te te ciles behet kontrollimi i parave te 
        //insertuara dhe zgjedhet opsioni per anulimin e procesit apo shfaqjen e produkteve te disponueshme
        public bool CheckMoney()
        {
            if (TotalMoney > 0 && TotalMoney < coke.price)
            {
                ListOfProductByPrice();
                Console.WriteLine("[-2] Refund Money");
                Console.WriteLine("[-1] If you dont want to enter more money!");
                Console.Write("\nEnter more coin: ");
                return false;
            }

            else if (TotalMoney >= coke.price)
            {
                ListOfProductByPrice();
                Console.WriteLine("[-2] Refund Money");
                Console.WriteLine("[-1] Complete Products List");
                return false;
            }
            else if (refundAndExit == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine();
                return false;
            }
        }

        //Metoda CheckProductAvailability e tipit string, e cila ne baze te parave te insertuara paraqet produktet qe mund te blihen 
        public string CheckProductAvailability()
        {
            string msg = null;
            ListOfProductByPrice();

            if (TotalMoney >= water.price && TotalMoney < coffee.price)
            {
                msg = "List of available product(s):\n[A] " + water.name + " - " + water.price
                        + " Euro\n[X] Enter more Money/Refund\n\nPlease note your selection:";

                Console.WriteLine(msg);

            }
            else if (TotalMoney >= coffee.price && TotalMoney < coke.price)
            {
                msg = "List of available product(s):\n[A] " + water.name + " - " + water.price + " Euro\n[B] " + coffee.name
                    + " - " + coffee.price + " Euro\n[X] Enter more Money/Refund\n\nPlease note your selection: ";

                Console.WriteLine(msg);
            }
            else if (TotalMoney >= coke.price)
            {
                msg = "List of available product(s):\n[A] " + water.name + " - " + water.price + " Euro\n[B] " + coffee.name + " - "
                    + coffee.price + " Euro\n[C] " + coke.name + " - " + coke.price + " Euro\n[X] Enter more Money/Refund\n\nPlease note your selection: ";

                Console.WriteLine(msg);
            }
            else
            {
                msg = "[X] Enter more Money/Refund: ";
                Console.WriteLine(msg);
            }

            return msg;
        }

        // Metoda DispenseProduct e tipit string, pranon si parameter nje karakter
        // sherben per te selektuar produktin
        public string DispenseProduct(char selection)
        {
            string mesage = null;

            // nese metoda pranon si parameter A per Water, parate e insertuara jane te mjaftueshme per blerje e produktit
            // dhe produkti i zgjedhur eshte ne stok atehere shfrytezuesi i paraqitet mesazhi me llogaritjet per produktin e blere
            if (selection == 'A')
            {
                if (TotalMoney >= water.price && water.instock > 0)
                {
                    mesage = "1. You have entered " + TotalMoney + " Euro\n2. You have bought " + water.name + " " + Pay(water.price) + " Euro\n3. Your change is " + ReturnChange(water.price) + " Euro";
                    Console.WriteLine(mesage);
                    Instock(water.name);
                    refundAndExit = true;
                    selectionDispence = true;
                }
                else // perndryshe pranon nje mesazh tjeter
                {
                    Console.Clear();
                    mesage = "Access to this product is restricted \n\n[X] To continue";
                    Console.WriteLine(mesage);
                }
            }
            // nese metoda pranon si parameter B per Coffee, parate e insertuara jane te mjaftueshme per blerje e produktit
            // dhe produkti i zgjedhur eshte ne stok atehere klientit i paraqitet mesazhi me llogaritjet per produktin e blere
            else if (selection == 'B')
            {
                if (TotalMoney >= coffee.price && coffee.Instock > 0)
                {
                    mesage = "1. You have entered " + TotalMoney + " Euro\n2. You have bought " + coffee.name + " " + Pay(coffee.Price) + " Euro\n3. Your change is " + ReturnChange(coffee.price) + " Euro";
                    Console.WriteLine(mesage);
                    Instock(coffee.name);
                    refundAndExit = true;
                    selectionDispence = true;
                }
                else // perndryshe pranon nje mesazh tjeter
                {
                    Console.Clear();
                    mesage = "Access to this product is restricted \n\n[X] To continue";
                    Console.WriteLine(mesage);
                }
            }
            // nese metoda pranon si parameter C per Coca-Cola, parate e insertuara jane te mjaftueshme per blerje e produktit
            // dhe produkti i zgjedhur eshte ne stok atehere shfrytezuesi i paraqitet mesazhi me llogaritjet per produktin e blere
            else if (selection == 'C')
            {
                if (TotalMoney >= coke.price && coke.Instock > 0)
                {
                    mesage = "1. You have entered " + TotalMoney + " Euro\n2. You have bought " + coke.name + " " + Pay(coke.price) + " Euro\n3. Your change is " + ReturnChange(coke.price) + " Euro";
                    Console.WriteLine(mesage);
                    Instock(coke.name);
                    refundAndExit = true;
                    selectionDispence = true;
                }
                else // perndryshe pranon nje mesazh tjeter
                {
                    Console.Clear();
                    mesage = "Access to this product is restricted \n\n[X] To continue";
                    Console.WriteLine(mesage);
                }
            }
            // nese metoda pranon si parameter X, shfrytezuesi ka mundesi te anuloje blerjen apo te vazhdon me insertimin e parave
            else if (selection == 'X')
            {
                Console.Clear();
                mesage = "Return/Refund";
                Console.Clear();
                selectionDispence = true;
            }
            else // nese metoda pranon qfare do parametri tjeter paraqitet porosia Invalid Selection...
            {
                mesage = "Invalid Selection. Please re-enter your selection";
                Console.WriteLine(mesage);
                selectionDispence = false;
            }

            return mesage;
        }

        //Metoda ReturnChange e tipit double, pranon parameter te tipit doubel
        //sherben per te kthyer mbetjen e parave pas blerjes
        public double ReturnChange(double number)
        {
            if (number > 0 && number < 4)  // nese vlera e pranur eshte me e madhe se zero kryhen llogaritjet per kthimin e kusurit
            {
                double change = (TotalMoney - number);
                TotalMoney = 0;
                return change;
            }
            else // perndryshe kthehen parate qe jane insertuar
            {
                return 0;
            }
        }

        // Metoda Pay e tipit double, pranon si parameter nje double
        // sherben per llogaritur pagesen per produktin e selektuar
        public double Pay(double number)
        {
            if (number > 0 && TotalMoney >= number) // nese plotesohet kushti, ktheht qmimi i produktit
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        //Metoda RefundMoney e tipit double, qe si parameter pranon nje double sherben per te kthyer parat e insertuaa ne rast te anulimit te blerjes
        public double RefundMoney(double number)
        {
            if (number > 0) // nese vlera qe pranon metoda eshte me i madh se zero, atehere behet llogaritja
            {
                Console.WriteLine("\nYour request to Refund is accepted. Please, take your " + number + "EURO.");
                TotalMoney = TotalMoney - number;
                Console.WriteLine("Press any key to exit");
                return number;
            }
            else // perndryshe paraqitet nje mesazh
            {
                Console.WriteLine("\nYour request to refund not accepted");
                Console.WriteLine();
                return 0;
            }
        }

        //Metoda ContinueOrRefunde tipit double, pranon nje parameter double, perdoret per insertimin e parave ne rastin kur deshirojme te vazhdojme pas qe nuk kena par ate mjaftueshe
        public bool ContinueOrRefund(double select) //Tested
        {
            if (select == 0.05)
            {
                TotalMoney += 0.05;
                refundAndExit = false;
                selectionDispence = true;
                Console.Clear();
                return refundAndExit;
            }
            else if (select == 0.10)
            {
                TotalMoney += 0.10;
                refundAndExit = false;
                selectionDispence = true;
                Console.Clear();
                return refundAndExit;
            }
            else if (select == 0.20)
            {
                TotalMoney += 0.20;
                refundAndExit = false;
                selectionDispence = true;
                Console.Clear();
                return refundAndExit;
            }
            else if (select == 0.50)
            {
                TotalMoney += 0.50;
                refundAndExit = false;
                selectionDispence = true;
                Console.Clear();
                return refundAndExit;
            }
            else if (select == 1.00)
            {
                TotalMoney += 1.00;
                selectionDispence = true;
                refundAndExit = false;
                Console.Clear();
                return refundAndExit;
            }
            else if (select == 2.00)
            {
                TotalMoney += 2.00;
                refundAndExit = false;
                selectionDispence = true;
                Console.Clear();
                return refundAndExit;
            }
            else if (select == -1)
            {
                refundAndExit = false;
                Console.Clear();
                CheckProductAvailability();
                return refundAndExit;
            }
            else if (select == -2)
            {
                Console.Clear();
                RefundMoney(TotalMoney);
                refundAndExit = true;
                return refundAndExit;
            }
            else
            {
                refundAndExit = false;
                Console.WriteLine("Invalid selection");
                return refundAndExit;
            }
        }

        // Metoda ListOfProductByPrice e tipit void, varesisht nga parate e insertuar tregon se sa pare jane te nevojshme per secilin produkt
        public void ListOfProductByPrice()
        {
            Console.WriteLine();
            Console.WriteLine("You have entered: " + TotalMoney + " EURO.");

            if (TotalMoney < water.price)
            {
                Console.WriteLine("To buy Water you need to add " + (water.price - TotalMoney) + " EURO more");
                Console.WriteLine("To buy Coffee you need to add " + (coffee.price - TotalMoney) + " EURO more");
                Console.WriteLine("To buy Coke you need to add " + (coke.price - TotalMoney) + " EURO more");
            }
            else if (TotalMoney < coffee.price)
            {
                Console.WriteLine("To buy Coffee you need to add " + (coffee.price - TotalMoney) + " EURO more");
                Console.WriteLine("To buy Coke you need to add " + (coke.price - TotalMoney) + " EURO more");
            }

            else if (TotalMoney < coke.price)
            {
                Console.WriteLine("To buy Coke you need to add " + (coke.price - TotalMoney) + " EURO more");
            }
            else if (TotalMoney >= coke.price)
            {
                Console.WriteLine("You don't need to enter more money!");
            }
            Console.WriteLine();
        }

        //Metoda CheckRefundMoney e tipi boolean, e cila pranon si parameter nje karakter, perdoret per te kontrolluar nese 
        // shfrytezuesi kerkon te beje Refund apo per te kontrolloj listen per selektim te produkteve, nese metoda pranon nje parametet 
        // tjeter athere shfrytezuesi ka munesi te permiresoje gabimin
        public bool CheckRefundMoney(char selection)
        {
            if (selection == 'R')
            {
                Console.WriteLine();
                Console.Clear();
                RefundMoney(TotalMoney);
                selectionCheck = true;
                refundAndExit = true;
                return refundAndExit;
            }
            else if (selection == 'C')
            {
                Console.Clear();
                selectionCheck = true;
                refundAndExit = false;
                return refundAndExit;
            }
            else
            {
                Console.WriteLine("Invalid Selection. Pleas re-enter your selection:");
                selectionCheck = false;
                refundAndExit = false;
                return refundAndExit;
            }
        }

        // Metoda Instock, me ane te ciles behet kalkulimi i produkteve ne stok
        // Metoda kthen rezultat te tipit int, ndersa si parametet pranon string
        public int Instock(string input)
        {
            int instock = 0;

            if (input == water.name) // nese metoda pranon si parameter produktin Water, behet kalkulim per stokun e ujit
            {
                Console.WriteLine("4. Instock was " + water.instock + " water");
                instock = water.instock = water.instock - 1;
                Console.WriteLine("5. Instock are " + water.instock + " water");
                return instock;
            }
            else if (input == coffee.name) // nese metoda pranon si parameter produktin Coffee, behet kalkulim per stokun e kafes
            {
                Console.WriteLine("4. Instock was " + coffee.instock + " coffee");
                instock = coffee.instock = coffee.instock - 1;
                Console.Write("5. Instock are " + coffee.instock + " coffee");
                return instock;
            }
            else if (input == coke.name) // nese metoda pranon si parameter produktin Coca-Cola, behet kalkulim per stokun e coca-cola
            {
                Console.WriteLine("4. Instock was " + coke.instock + " coke");
                instock = coke.instock = coke.instock - 1;
                Console.WriteLine("5. Instock are " + coke.instock + " coke");
                return instock;
            }
            else // nese metoda pranon input tjeter kthen "Wrong selection"
            {
                Console.WriteLine("Wrong selection.!");
                Console.WriteLine(instock = 0);
                return 0;
            }
        }
    }
}