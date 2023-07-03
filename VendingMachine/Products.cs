using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Products 
    {
        // Atributet e klases produkt
        public string name;
        public double price;
        public int instock;

        // Konstruktori ku behet incializimi i atributeve te produktit
        public Products(string productName, double productPrice, int productStock)
        {
            name = productName;
            price = productPrice;
            instock = productStock;
        }
        
        // Metoda Name kthen emrin e produktit
        public string Name
        {
            get
            {
                return name;
            }
        }

        //Metoda Price kthen cmimin e produktit
        public double Price
        {
            get
            {
                return price;
            }
        }

        //Metoda Instock kthen sasine e produkteve
        public double Instock
        {
            get
            {
                return instock;
            }
        }
    }
}