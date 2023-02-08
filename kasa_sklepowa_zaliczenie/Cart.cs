using System;
using System.Collections.Generic;

namespace kasa_sklepowa_zaliczenie
{
    internal partial class Program
    {
        public class Cart
        {
            private List<Item> items;

            public Cart()
            {
                items = new List<Item>();
            }

            public void addToCart(Item item)
            {
                items.Add(item);
            }

            public double getCartAmount()
            {
                double sum = 0;

                foreach (Item item in items)
                {
                    sum += item.getPriceGross();
                }

                return sum;
            }

            public double getCartVatAmount()
            {
                double sum = 0;

                foreach (Item item in items)
                {
                    sum += item.getSumVat();
                }

                return sum;
            }

            public void getParagon()
            {
                string data = DateTime.Now.ToString("MM/dd/yyyy");

                Console.WriteLine("Data zakupu:" + data);
                Console.WriteLine("-----------");

                foreach (Item item in items)
                {
                    Console.WriteLine(item.getName() + " " + item.getPriceGross() + " zł");
                }

                Console.WriteLine("-----------");
                Console.WriteLine("Do zapłaty: " + getCartAmount() + " zł \nw tym vat: " + getCartVatAmount() + " zł");
            }
        }
    }
}
